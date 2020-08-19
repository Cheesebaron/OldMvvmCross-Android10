# Samples showing how target Android 10 with old MvvmCross versions

MvvmCross versions prior to version 6.4.1 do not support Android 10, due to some missing implementations in MvxLayoutInflater.

This sample show how to patch MvxLayoutInflater, MvxContextWrapper and MvxActivity such that they can target Android 10.

Read more about the issue here: https://blog.ostebaronen.dk/2020/08/old-mvvmcross-and-android-10.html

All the bits containing the fixes are in the classes starting with `Fixed`. This includes
- FixedLayoutInflaterCompat
- FixedLayoutInflater
- FixedContextWrapper
- FixedActivity

Feel fee to copy/paste the code into your own App.