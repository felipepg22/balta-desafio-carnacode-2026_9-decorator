![ES-4](https://github.com/user-attachments/assets/a2e54098-8641-46ca-8c71-399f54624d9f)

## 🥁 CarnaCode 2026 - Challenge 09 - Decorator

Hi, I'm Felipe Parizzi Galli, and this is where I share my learning journey during the **CarnaCode 2026** challenge, hosted by [balta.io](https://balta.io). 👻

Here you will find projects, exercises, and code I am building during the challenge. The goal is to get hands-on, test ideas, and document my growth in technology.

### About this challenge

In the **Decorator** challenge, I had to solve a real-world problem by implementing the corresponding **Design Pattern**.  
Throughout this process, I learned:

- ✅ Software best practices
- ✅ Clean code
- ✅ SOLID
- ✅ Design Patterns

## Problem

A coffee shop offers base drinks (Coffee, Cappuccino, Tea) and multiple add-ons (Milk, Chocolate, Chantilly, Caramel). The original code created one class for each possible combination, causing class explosion and duplicated code.

## About CarnaCode 2026

The **CarnaCode 2026** challenge consists of implementing all 23 design patterns in real-world scenarios. Across the 23 challenges in this journey, participants practice identifying non-scalable code and solving problems with industry-standard patterns.

### eBook - Design Pattern Fundamentals

My main learning resource during the challenge was the free eBook [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

## How the Decorator Pattern Was Implemented

The implementation uses a common contract (`ICoffee`) with `GetCost()` and `GetDescription()`.

- Base beverages implement `ICoffee` directly:
`Espresso` and `Cappuccino`.
- A base decorator class (`CoffeeDecorator`) also implements `ICoffee` and wraps another `ICoffee` instance.
- Concrete decorators extend `CoffeeDecorator` and add behavior:
`MilkDecorator`, `ChocolateDecorator`, and `ChantillyDecorator`.
- Each concrete decorator adds its own value to the base price and appends its name to the description, allowing dynamic composition at runtime.

Example composition:
`new ChantillyDecorator(new ChocolateDecorator(new MilkDecorator(new Cappuccino())))`
