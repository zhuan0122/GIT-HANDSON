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