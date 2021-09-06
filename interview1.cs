1. Перевернуть список

public class ListNode
{
  int val;
  ListNode next;
  ListNode (int x){
	val=x;
    next=null;
  }
}

public static Reverse(ListNode head) {
  ListNode node, nodeNext, nodeFirst;
  nodeFirst=head;
  While(head.next!=null){
    
    node=head;
    head=head.next;
    head.next=node;  	
  }
  nodeFirst.next=null;
}

public static Reverse(ListNode head) {
  ListNode prevNode = null 
      
  while (head != null) {
  	ListNode nextNode = head.next
    head.next = prevNode
    prevNode = head
    head = nextNode
  }
}


2.
a) Из массива n (n=10^8) различных чисел [1,n] выбросили одно число. Нужно его определить.
b) Два числа?

3. На вход подается натуральное число N [1,10^5]

- Вывести на экран Fizz, если N кратно 3
- Вывести на экран Buzz, если N кратно 5
- Вывести на экран FizzBuzz, если N кратно 15

public void FizzBuzz(int x){
  if (x % 3 ==0) {
    Console.Write("Fizz");
  }
  if (x % 5 ==0) {
    Console.Write("Buzz");
  }
  Console.WriteLine()
}

