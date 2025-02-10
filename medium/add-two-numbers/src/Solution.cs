namespace src;

public static class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var dummyHead = new ListNode();
        var current = dummyHead;
        var carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return dummyHead.next;
    }
}
