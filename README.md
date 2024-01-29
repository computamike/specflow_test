# specflow_test
A test repository giving a simple example that can be used to test the issue raised in BlogPost https://support.specflow.org/hc/en-us/community/posts/4404727320593-All-Specflow-MSTests-running-in-the-background-after-single-test-run-when-started-from-Visual-Studio-Test-Explorer

## How this code works 
When the test executes, it writes a log into the test_explorer.log file, that will be located on your desktop.

With Fine Code Coverage extension enabled - this seemed to cause the test to execute twice.

![Fine Code Coverage Extension shown as enabled in Extensions](images/Fine%20Code%20Coverage%20Extension%20enabled.png)


Contents from the log after selecting the test in VS Test Explorer and picking "Run".
```
1/29/2024 12:29:13 AM Tst Add two numbers
1/29/2024 12:29:22 AM Tst Add two numbers
```

