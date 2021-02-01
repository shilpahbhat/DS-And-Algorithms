using System;
using System.Collections.Generic;
using System.Text;

namespace Solved_Problems
{
    class LinkedListProblems
    {
        //reverse linked list
        //reverse doubly linked list
        //find number of nodes in linked list
        //find middle element in linked list
        //find if linked list is circular
        //add two numbers
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //Add head nodes 
            // if overflow,i.e. divide by 10 !=0, then save carry to add in the next loop
            // save answer digit -- i.e mod 10 in the answer linked list
            int carry = 0;
            ListNode result = new ListNode(0);

            while (l1 != null && l2 != null)
            {

                int sum = l1.val + l2.val + carry;
                carry = sum / 10;
                sum = sum % 10;
                l1 = l1.next;
                l2 = l2.next;
                result.val = sum;
                result.next = new ListNode(0);
                result = result.next;
            }




            return result;
        }
        /*You are given two linked-lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

Example:
Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.*/

    }
}
