# Linked List Implementations in C#

A comprehensive collection of linked list data structure implementations in C#, featuring clean code, detailed comments, time complexity annotations, and test cases.

---

## 📚 Overview

This repository provides clear, object-oriented implementations of three fundamental linked list variants:

1. **Singly Linked List (`SinglyLinkedList.cs`)**: Each node links to the next node in a unidirectional sequence.
2. **Doubly Linked List (`DoublyLinkedList.cs`)**: Each node maintains references to both the previous (`Prev`) and next (`Next`) nodes, with efficient head and tail pointers.
3. **Circular Linked List (`CircularLinkedList.cs`)**: The last node links back to the head node, forming a continuous cycle.

---

## 📁 Project Structure

```text
Linked List/
├── SinglyLinkedList.cs     # Singly Linked List implementation & driver code
├── DoublyLinkedList.cs     # Doubly Linked List implementation & driver code
├── CircularLinkedList.cs   # Circular Linked List implementation & driver code
└── README.md               # Documentation and usage guide
```

---

## ⚡ Supported Operations

Each linked list includes standard CRUD and traversal operations:

- **Insert at Beginning**: Add a new node at the start of the list.
- **Insert at End**: Append a new node to the end of the list.
- **Insert at Position**: Insert a node at any specified 0-based index.
- **Delete from Beginning**: Remove the head node.
- **Delete from End**: Remove the last node.
- **Delete at Position**: Remove a node from a specified 0-based index.
- **Search**: Search for a value and return its position/index.
- **Update**: Update the value of a node at a specified position.
- **Traverse / Display**: Print a visual representation of the linked list with pointers.

---

## ⏱️ Time Complexity Analysis

| Operation | Singly Linked List | Doubly Linked List (with Tail) | Circular Linked List |
| :--- | :---: | :---: | :---: |
| **Insert at Beginning** | $O(1)$ | $O(1)$ | $O(n)$ |
| **Insert at End** | $O(n)$ | $O(1)$ | $O(n)$ |
| **Insert at Position** | $O(n)$ | $O(n)$ | $O(n)$ |
| **Delete from Beginning** | $O(1)$ | $O(1)$ | $O(n)$ |
| **Delete from End** | $O(n)$ | $O(1)$ | $O(n)$ |
| **Delete at Position** | $O(n)$ | $O(n)$ | $O(n)$ |
| **Search** | $O(n)$ | $O(n)$ | $O(n)$ |
| **Update at Position** | $O(n)$ | $O(n)$ | $O(n)$ |
| **Traversal** | $O(n)$ | $O(n)$ | $O(n)$ |

---

## 🚀 How to Run

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0+ recommended) or C# Compiler (`csc`).

### Option 1: Running with .NET CLI
Run any single file directly using the `dotnet` script execution feature:

```bash
# Run Singly Linked List
dotnet run SinglyLinkedList.cs

# Run Doubly Linked List
dotnet run DoublyLinkedList.cs

# Run Circular Linked List
dotnet run CircularLinkedList.cs
```

### Option 2: Compiling with `csc`
```bash
# Compile and run SinglyLinkedList
csc SinglyLinkedList.cs
./SinglyLinkedList.exe

# Compile and run DoublyLinkedList
csc DoublyLinkedList.cs
./DoublyLinkedList.exe

# Compile and run CircularLinkedList
csc CircularLinkedList.cs
./CircularLinkedList.exe
```

---

## 💻 Sample Output Visualization

### Singly Linked List
```text
Current List: Head -> [ 10 | • ] -> [ 20 | • ] -> [ 30 | • ] -> null
```

### Doubly Linked List
```text
Forward List:  Head <-> [ • | 10 | • ] <-> [ • | 20 | • ] <-> [ • | 30 | • ] <-> Tail
Backward List: Tail <-> [ • | 30 | • ] <-> [ • | 20 | • ] <-> [ • | 10 | • ] <-> Head
```

### Circular Linked List
```text
Current List: Head -> [ 10 | • ] -> [ 20 | • ] -> [ 30 | • ] -> (Back to Head)
```

---

## 📄 License
This repository is open-source and intended for educational purposes. Feel free to use and adapt the code for learning and projects.
