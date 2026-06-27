# Exercise 1 - Write Testable Code with Moq

## Objective

The objective of this exercise is to learn how to write testable code using the Moq Framework and NUnit. The application uses dependency injection to mock the mail sender and verify the functionality without sending an actual email.

## Project Structure

```
CustomerComm
│
├── CustomerCommLib
│   ├── CustomerComm.cs
│   ├── IMailSender.cs
│   └── MailSender.cs
│
└── CustomerComm.Tests
    └── CustomerCommTests.cs
```

## Technologies Used

- C#
- .NET
- NUnit
- Moq
- Visual Studio 2022

## Test Result

- Total Tests: 1
- Passed: 1
- Failed: 0
- Skipped: 0

## Output

The test was executed successfully using the NUnit Test Explorer. The Moq framework was used to create a mock object for the mail sender, and the test verified that the `SendMailToCustomer()` method returned `true`.
