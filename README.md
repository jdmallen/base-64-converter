# Base 64 Converter

Quick & dirty Windows Forms app written in .NET Core 3.1 to convert a textarea to/from Base64, encode files to Base64, and prettify JSON and XML after it has been decoded.

I wrote this after finding I need to frequently decode JWTs and SAML assertions, and not always trusting browser extensions to do it securely.

This thing is like 3 classes, only one of which isn't auto-gen, and is less than 200 lines of code. You can easily verify that it won't send your sensitive stuff across the web when you use it. But, ya know, MIT License, so don't sue me if it somehow does.

Cheers.
