# Description

A function that takes one string input of any number of integers separated by single whitespace. 
The function then outputs the longest increasing subsequence (increased by any number) present in that sequence. 


## Test Environment

In project root folder, please run following commands to see the test results.

```
docker-compose run test
```

## CI Pipeline

`GitHub Actions` is used as CI pipline. The workflow will be triggered when new push comes into the master branch. 
The workflow logs the test results and also verify code quality using `Super Linter` as a separete job.
