﻿using System;

namespace SinglySimple
{
    class Program
    {
        public class PersonNode
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public PersonNode Next { get; set; }

            public PersonNode(string first, string last)
            {
                this.FirstName = first;
                this.LastName = last;
                this.Next = null;
            }
        }
        public class PersonNodeList
        {
            private PersonNode head;

            public void Add(PersonNode pers)
            {
                if(head == null)
                {
                    head = pers;
                }

                PersonNode temp = head;
                // find the last node
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = pers;
                // ensure that this is the last node
                pers.Next = null;
            }
            public void DisplayAll()
            {
                PersonNode temp = head;
                do
                {
                    Console.WriteLine(string.Format("{0} {1}", temp.FirstName, temp.LastName));
                    temp = temp.Next;
                } while (temp != null);
            }
            public bool InsertAfter(PersonNode pExisting, PersonNode pNew)
            {
                PersonNode temp = head;
                do
                {
                    if (temp.FirstName == pExisting.FirstName && temp.LastName == pExisting.LastName)
                    {
                        pNew.Next = temp.Next;
                        temp.Next = pNew;
                        return true;
                    }
                    temp = temp.Next;
                } while (temp != null);
                return false;
            }
            public bool Remove(PersonNode pers)
            {
                PersonNode temp = head;
                // is it the first node?
                if (temp.FirstName == pers.FirstName && temp.LastName == pers.LastName)
                {
                    // check if only single node
                    if (temp.Next == null)
                    {
                        // currently, cannot allow empty list
                        return false;
                    }
                    else
                    {
                        head = head.Next;
                        return true;
                    }
                }
                while (temp.Next != null)
                {
                    PersonNode prev = temp;
                    temp = temp.Next;
                    if (temp.FirstName == pers.FirstName && temp.LastName == pers.LastName)
                    {
                        prev.Next = temp.Next;
                        return true;
                    }
                }
                return false;
            }
        }

        static void Main2(string[] args)
        {
            PersonNodeList personList = new PersonNodeList();
            personList.Add(new PersonNode("Peter", "Griffin"));
            personList.Add(new PersonNode("Ted", "Jones"));
            personList.Add(new PersonNode("Mary", "Bourbon"));

            personList.DisplayAll();

            personList.Remove(new PersonNode("Peter", "Griffin"));

            Console.WriteLine("Peter removed..");
            personList.DisplayAll();

            personList.InsertAfter(new PersonNode("Ted", "Jones"), new PersonNode("Fred", "Fiddle"));

            Console.WriteLine("Fred inserted after Ted..");
            personList.DisplayAll();

            Console.ReadKey();
        }
    }
}
