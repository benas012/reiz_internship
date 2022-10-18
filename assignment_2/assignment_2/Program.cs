// See https://aka.ms/new-console-template for more information
using assignment_2;


// 1st Layer
Branch root = new Branch();

// 2nd Layer
root.branches.Add(new Branch());
root.branches.Add(new Branch());

// 3rd Layer
root.branches[0].branches.Add(new Branch());

root.branches[1].branches.Add(new Branch());
root.branches[1].branches.Add(new Branch());
root.branches[1].branches.Add(new Branch());

// 4th Layer

root.branches[1].branches[0].branches.Add(new Branch());

root.branches[1].branches[1].branches.Add(new Branch());
root.branches[1].branches[1].branches.Add(new Branch());

root.branches[1].branches[2].branches.Add(new Branch());

// 5th Layer

root.branches[1].branches[1].branches[0].branches.Add(new Branch());


// 6th Layer

root.branches[1].branches[1].branches[0].branches[0].branches.Add(new Branch());

Console.WriteLine(Logic.CalculateBranchHeight(root));
