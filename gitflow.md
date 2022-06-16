## GIT Commands 
1, when you want to detele  a branch. you must not checkout current branch. then you cannot deleteit with error: error: Cannot delete branch 'task1_name' checked out at 'C:/Users/zhuan/cShaper/C-StudyNotes'

* detele branches:
	git branch -a  //list all branches first both local and remote 

	git branch -d local_branch b1 //detele  this local branch b1

	git push origin --delete b1 // delete the mapping remote b1 branch which is mapped to local b1

	git branch -a // check the left branches again 

* If you creat a feature branch from local develop branch. Then someone updated develop branch and push it to remote develop
then you checkout develop branch and git pull to get updates but if you git diff develop feature then it will show diff between these two branch 
so this mean your local feature branch is out of date from develop but if you need these new changes that someone else did in develop
then you could do is checkout your feature branch and git merge develop there. Then you git diff develop feature again. It will have nothing to pop up. 

* some changes were done in local branch, so it is some commits head of its tracking remote branch. I want to ignore or revert the change and make it as the same as remote branh

2529

Delete the most recent commit, keeping the work you've done:
git reset --soft HEAD~1

Delete the most recent commit, destroying the work you've done:
git reset --hard HEAD~1


This will unstage all files you might have staged with git add:
git reset

This will revert all local uncommitted changes (should be executed in repo root):
git checkout .

You can also revert uncommitted changes only to particular file or directory:
git checkout [some_dir|file.txt]

Yet another way to revert all uncommitted changes (longer to type, but works from any subdirectory):
git reset --hard HEAD

This will remove all local untracked files, so only git tracked files remain:
git clean -fdx
WARNING: -x will also remove all ignored files, including ones specified by .gitignore! You may want to use -n for preview of files to be deleted.


To sum it up: executing commands below is basically equivalent to fresh git clone from original source (but it does not re-download anything, so is much faster):
git reset
git checkout .
git clean -fdx


* show git graph:  git log --graph --all

* check current branch's parent branch or check when you created it from which branch: 
git log , this will show where the current branch is created from.
As explained in many places, it is not a direct parent, it gives you nearest branch which from current branch is created or shares same HEAD


* difference between vi, cat, touch : https://towardsai.net/p/l/fully-explained-difference-between-cat-touch-vi-vim-and-nano-in-linux


* check the creator of all remote branch and sorted by commiteddate
  git for-each-ref --format='%(committerdate) %09 %(authorname) %09 %(refname)' --sort=committerdate

* undo all uncommited changes: git checkout . 
* undo changes in one or several files: git checkout [some_dir|file.txt] -- some_dir is directory path
* undo all added changes in state: git reset


* how to back specific version in your local branch? 
  1. git reflog show ----show all history in your branch 
  2. find the version Id that you want to go back and use git reset --hard idxxx. 

* git reflog --date=local --all 