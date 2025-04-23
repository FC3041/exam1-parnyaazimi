// namespace Exam1.Test;

// [TestClass]
// public class UnitTest1
// {
//     [TestMethod]
//     public void TestMethod1()
//     {
//     }
//     [TestMethod]
//     public void Q1_AddTest()
//     {
//         // Assert.Inconclusive();

//         // Test Case 1: Two positive numbers
//         Assert.AreEqual(8, Q1_Add.Add(5, 3));

//         // Test Case 2: Positive and negative number
//         Assert.AreEqual(5, Q1_Add.Add(7, -2));

//         // Test Case 3: Two negative numbers
//         Assert.AreEqual(-10, Q1_Add.Add(-4, -6));

//         // Test Case 4: Zero and a number
//         Assert.AreEqual(9, Q1_Add.Add(0, 9));

//         // Test Case 5: Two zeros
//         Assert.AreEqual(0, Q1_Add.Add(0, 0));
//     }

//     [TestMethod]
//     public void Q2_MultiplyAndReset_AllCases()
//     {
//         // Assert.Inconclusive();

//         // Case 1: normal values
//         {
//             int v = 3, f = 5;
//             Basics.Q2MultiplyAndReset(ref v, ref f);
//             Assert.AreEqual(15, v);
//             Assert.AreEqual(1, f);
//         }

//         // Case 2: zero value
//         {
//             int v = 0, f = 7;
//             Basics.Q2MultiplyAndReset(ref v, ref f);
//             Assert.AreEqual(0, v);
//             Assert.AreEqual(1, f);
//         }

//         // Case 3: negative factor
//         {
//             int v = 10, f = -2;
//             Basics.Q2MultiplyAndReset(ref v, ref f);
//             Assert.AreEqual(-20, v);
//             Assert.AreEqual(1, f);
//         }

//         // Case 4: factor already one
//         {
//             int v = 6, f = 1;
//             Basics.Q2MultiplyAndReset(ref v, ref f);
//             Assert.AreEqual(6, v);
//             Assert.AreEqual(1, f);
//         }

//         // Case 5: large values
//         {
//             int v = 1000, f = 1000;
//             Basics.Q2MultiplyAndReset(ref v, ref f);
//             Assert.AreEqual(1_000_000, v);
//             Assert.AreEqual(1, f);
//         }
//     }
//     // Uncomment Before attempting Q3
//     static void Q3Increment(Type1 t1, Type2 t2)
//     {
//         // value‐type: incrementing the copy → no persistence
//         t1.Count += 1;
//         // reference‐type: incrementing the instance → persists
//         t2.Count += 1;
//     }


//     [TestMethod]
//     public void Q3_Increment_AllCases()
//     {
//         // Assert.Inconclusive();

//         // !!!! Uncomment the Q3Increment method above before running this test !!!!

//         // Case 1: both start at 0
//         {
//             var t1 = new Type1 { Count = 0 };
//             var t2 = new Type2 { Count = 0 };
//             Q3Increment(t1, t2);
//             Assert.AreEqual(0, t1.Count, "Type1 should remain unchanged (value type)");
//             Assert.AreEqual(1, t2.Count, "Type2 should be incremented (reference type)");
//         }

//         // Case 2: both start positive
//         {
//             var t1 = new Type1 { Count = 5 };
//             var t2 = new Type2 { Count = 5 };
//             Q3Increment(t1, t2);
//             Assert.AreEqual(5, t1.Count);
//             Assert.AreEqual(6, t2.Count);
//         }

//         // Case 3: both start negative
//         {
//             var t1 = new Type1 { Count = -2 };
//             var t2 = new Type2 { Count = -2 };
//             Q3Increment(t1, t2);
//             Assert.AreEqual(-2, t1.Count);
//             Assert.AreEqual(-1, t2.Count);
//         }
//     } 

//     [TestMethod]
//     public void Q4_Person_AllCases()
//     {
//         // Assert.Inconclusive();

//         // Case 1: typical name and age
//         {
//             var p = new Q4Person("Alice", 30);
//             Assert.AreEqual("Alice", p.Name);
//             Assert.AreEqual(30,     p.Age);
//             Assert.AreEqual(
//                 "Hello, my name is Alice and I am 30 years old.",
//                 p.Introduce()
//             );
//         }

//         // Case 2: empty name and zero age
//         {
//             var p = new Q4Person("", 0);
//             Assert.AreEqual("", p.Name);
//             Assert.AreEqual(0,  p.Age);
//             Assert.AreEqual(
//                 "Hello, my name is  and I am 0 years old.",
//                 p.Introduce()
//             );
//         }
        
//     }  
// }