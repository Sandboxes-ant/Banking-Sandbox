# Banking-Sandbox
Hello and welcome to the Thrys Banking solutions. What we are trying to accomplish is to be the best banking company in the world.
However, we do not have any systems yet so we have to build that from the ground up. That is where you come in. 

## Playing rules
What we want you to do is to submit you solutions in iterations. When you have completed one iteration then a new one appears approximately one week after that you can work on. 

### What is an iteration?
An iteration for us is a task that we want you to complete before we continue developing further with our product. In our world iterations can vary in size.

Every iteration comes with some certain demands. You have to use C#. However, how you solve it in C# doesn't matter(unless some specific demands says other wise). 

### How to complete an iteration?
When you think that you are done with a feature, the you create a Pull Request into master. Write a message to the CEO (Andreas Tietgen) that you have created the pull request. Then he will see if everything is as expected

### Can i get any help?
Yes of course you can! Our budget has room for consulting the C# expert, Andreas Tietgen. Remember you can always ask us(Andreas Tietgen) questions if the iteration description is unclear.

## Iterations

### Iteration 1 - The basics of an account
What we want to create here is some of the basics of an account. What is the basic abilities of an account?

- It has to hold some amount of money (However it can be 0)
- It cannot go below 0
- If you want to withdraw some money from the account then you have to be sure that the account has sufficient amount of money in order to make the withdrawal.
- You can insert money

An account should at least how the following properties:
- Id
- Balance

We want you to print out examples in the console that demonstrates every ability.
Remember! We start small, and then build on top of it:-)

### Iteration 2 - We want more!
Now that the basics of an account has be set up and defined in a simple console program then we want to extend it. 
This iteration is going to be large one.

- We want you to define an interface, called `IAccount`, with the basic properties and functions of an account. 
  - The definition of the interface should look like the same as the above properties and abilities that we gave an account in the last iteration
- We want you to create a class called `Account`, which implements the properties and functions of an account
  - The implementation is going to look like the code you have implemented in iteration 2

With the `Account` specified as a class and an interface then we would like you to extend the console user interface to be able to display a list of accounts. 
Also to choose which account to withdraw from.
