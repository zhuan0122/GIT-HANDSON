1. git 
1, when you want to detele  a branch. you must not checkout current branch. then you cannot deleteit with error: error: Cannot delete branch 'task1_name' checked out at 'C:/Users/zhuan/cShaper/C-StudyNotes'

2. detele branches:
	git branch -a  //list all branches first both local and remote 

	git branch -d local_branch b1 //detele  this local branch b1

	git push origin --delete b1 // delete the mapping remote b1 branch which is mapped to local b1

	git branch -a // check the left branches again 

3. If you creat a feature branch from local develop branch. Then someone updated develop branch and push it to remote develop
then you checkout develop branch and git pull to get updates but if you git diff develop feature then it will show diff between these two branch 
so this mean your local feature branch is out of date from develop but if you need these new changes that someone else did in develop
then you could do is checkout your feature branch and git merge develop there. Then you git diff develop feature again. It will have nothing to pop up. 

3. some changes were done in local branch, so it is some commits head of its tracking remote branch. I want to ignore or revert the change and make it as the same as remote branh