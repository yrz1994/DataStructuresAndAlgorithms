# 常见数据结构与算法总结
![CI](https://img.shields.io/github/workflow/status/yrz1994/DataStructuresAndAlgorithms/.NET%205%20CI)
![License](https://img.shields.io/github/license/yrz1994/DataStructuresAndAlgorithms)
## 时间复杂度

![image](https://user-images.githubusercontent.com/18241650/111873059-805de100-89c9-11eb-9f93-71c3adfd97af.png)

## 排序算法

| 排序算法 | 平均时间复杂度 | 最好情况 | 最坏情况 | 空间复杂度 | 稳定性 |
| ----------- | ----------- | ----------- | ----------- | ----------- | ----------- |
| [冒泡排序](https://github.com/yrz1994/DataStructuresAndAlgorithms/blob/main/src/SortingAlgorithm.Core/BubbleSort.cs) | O(n^2) | O(n) | O(n^2) | O(1) | 稳定 |
| [选择排序](https://github.com/yrz1994/DataStructuresAndAlgorithms/blob/main/src/SortingAlgorithm.Core/SelectionSort.cs) | O(n^2) | O(n^2) | O(n^2) | O(1) | 不稳定 |
| [插入排序](https://github.com/yrz1994/DataStructuresAndAlgorithms/blob/main/src/SortingAlgorithm.Core/InsertionSort.cs) | O(n^2) | O(n) | O(n^2) | O(1) | 稳定 |
| [希尔排序](https://github.com/yrz1994/DataStructuresAndAlgorithms/blob/main/src/SortingAlgorithm.Core/ShellSort.cs) | O(N^3/2) | O(nlog2n) | O(N^3/2) | O(1) | 不稳定 |
| [归并排序](https://github.com/yrz1994/DataStructuresAndAlgorithms/blob/main/src/SortingAlgorithm.Core/MergeSort.cs) | O(nlogn) | O(nlogn) | O(nlogn) | O(n) | 稳定 |
| [快速排序](https://github.com/yrz1994/DataStructuresAndAlgorithms/blob/main/src/SortingAlgorithm.Core/QuickSort.cs) | O(nlogn) | O(nlogn) | O(n^2) | O(nlog n) | 不稳定 |
| 堆排序 | O(nlogn) | O(nlogn) | O(nlogn) | O(1) | 不稳定 |
| 计数排序 | O(n+k) | O(n+k) | O(n+k) | O(k) | 稳定 |
| 桶排序 | O(n+k) | O(n+k) | O(n^2) | O(n+k) | 稳定 |
| 基数排序 | O(n+k) | O(n+k) | O(n+k) | O(n+k) | 稳定 |
