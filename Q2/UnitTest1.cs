using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q1;

namespace Q2 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestExample1() {
            int[] ret = Class1.FindLargest3Sums(
                new int[] {
                    1,2,2,5,7,3,7,8,9,26,16,1,2,3,1,4,5,1
                }
            );
            CollectionAssert.AreEqual(new int[] { 43, 24, 15 }, ret);
        }
        [TestMethod]
        public void TestExample2() {
            int[] ret = Class1.FindLargest3Sums(
                new int[] {
                    3,7,9,5,3,56,8,0,2,56,7,6,4
                }
            );
            CollectionAssert.AreEqual(new int[] { 69, 64, 19 }, ret);
        }
        [TestMethod]
        public void TestEmpty() {
            int[] ret = Class1.FindLargest3Sums(
                new int[] {}
            );
            CollectionAssert.AreEqual(new int[] { 0, 0, 0 }, ret);
        }
        [TestMethod]
        public void Test1() {
            int[] ret = Class1.FindLargest3Sums(
                new int[] { 7 }
            );
            CollectionAssert.AreEqual(new int[] { 7, 0, 0 }, ret);
        }
        [TestMethod]
        public void Test2() {
            int[] ret = Class1.FindLargest3Sums(
                new int[] { 3, 4 }
            );
            CollectionAssert.AreEqual(new int[] { 7, 0, 0 }, ret);
        }
        [TestMethod]
        public void TestTie() {
            int[] ret = Class1.FindLargest3Sums(
                new int[] { 3, 4, 1, 1, 1, 6, 1, 2, 3, 9 }
            );
            CollectionAssert.AreEqual(new int[] { 9, 8, 8 }, ret);
        }
    }
}
