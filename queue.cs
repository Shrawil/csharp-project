using System;

namespace LearningCShart {
    class Program{
        static int size = 5;
        
        static int isFull(int back) {
            if (back == size - 1) return 1;
            return 0;
        }
        
        static int isEmpty(int front) {
            if (front == -1) return 1;
            return 0;
        }
        
        static void printQue(int[] queue, int front, int back) {
            int i;
            Console.WriteLine();
            for(i=0; i<size; i++) {
                if(i==front) Console.Write("Front\t");
                else Console.Write("\t");
            }
            Console.WriteLine();
            for(i=0; i<size; i++) {
                Console.Write("{0}\t", queue[i]);
            }
            Console.WriteLine();
            for(i=0; i<size; i++) {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
            for(i=0; i<size; i++) {
                if(i==back) Console.Write("Back\t");
                else Console.Write("\t");
            }
        }
        
        static int addQueue(int[] queue, int front, int back, int elem) {
            if (isFull(front)) {
                Console.WriteLine("Queue is full!");
                return 0;
            }
            if (front == -1) front++;
            queue[++back] = elem;
        }
        
        static void delQueue(int[] queue, int front)
        
        static void Main(string[] args) {
            //Queue System
            int front = -1, back = -1;
            int[] queue = new int[size];
            printQue(queue, front, back);
            addQue(queue, front, back, elem);
        }
    }
}
