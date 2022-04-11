using System;

namespace Delete_the_Middle_Node_of_a_Linked_List
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
        this.val = val;
        this.next = next;
      }
    }

    public ListNode DeleteMiddle(ListNode head)
    {
      if (head.next == null) return null;
      if (head.next.next == null)
      {
        head.next = null;
        return head;
      }
      ListNode slow = head;
      ListNode fast = head;
      ListNode prev = head;
      while (fast != null && fast.next != null)
      {
        prev = slow;
        slow = slow.next;
        fast = fast.next.next;
      }
      prev.next = slow.next;
      return head;
    }
  }
}
