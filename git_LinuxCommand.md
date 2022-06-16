// my command lines file 

//linux command line
cd .. //return to the directory one level up 
cd ~ //go to the root directory 
pwd //show the current directory 
cd ~/Documents/  //navigate to document folder in your local computer 
rmdir folder_name //remove the empty folder 
rm -r folder_name // if the folder is not empty then use rm -r to remove folder and its contents 
rm -rf dir1 // https://linuxize.com/post/remove-directory-linux/
rm -d folder_name //To delete an empty directory, use the -d (--dir) option 
rm -r dir1 dir2 dir3 //o remove multiple directories at once 
rm -rI dir1 //The -i option tells rm to prompt you to confirm the deletion of each subdirectory and file. If the directory contains a lot of files, 
            //this can be a little annoying, 
           //so you may consider using the -I option what will prompt you only once before proceeding with the deletion.

mv files name(navigate to files location first) targeted_path(pwd in target location to get it) //move files to location
mv file_name_old new_file_name // change files name 

3. short cut to open git bash from windows: 
change start in path in git bash property location and remove --cd-to-home

%HOMEDRIVE%%HOMEPATH%
C:\Users\HZHSXR\AppData\Local\Programs\Git\git-bash.exe -cd-to-home

   4. clone push cannot access error: 1. delete http an https in variable setting. then run git command to set global proxy : git config --global --unset http.proxy
but if you do so you will cannot git clone and pull from scania ST2 project since you have changed your global proxy setting above. which has no acess to this specific scania proxy- how to solve this? 
follow this below: 
 Create your local work folder (ex. c:\GitWork)
* Right-click on folder and select “TortoiseGit | Settings”
* In Network set Proxy-address: proxyseso.scania.com and Port: 8080, give usernmae and password: login password
* Right-click on folder and select Git Clone… here it needs your token access and git clone link. 

if you have set the proxy in TortoiseGit before but you get the same error then I think you need to go to setting again and enable the proxy
but you might cannot enable it since you got the bad file in .gitconfig. 
it is empty there and may says it does not exist 
what you can do is > go to git bash, type to where you store .gitconfig usually it is cd /p 
then delete the .gitconfig file by rm -gitconfig 
then create one touch .gitconfig 
then go to tortisesetting again to enable. 

access denied to remove .gitconfig 