# POC Token JWT API

This is a demo API that demonstrates the **JWT Authentication** flow in ASP.NET Core: token generation in the authentication controller and automatic validation on protected routes.

## Features

- **JWT Login**: Endpoint that validates credentials and returns a token signed with HMAC SHA256.
- **Protected and Open Routes**: Examples of public endpoints (`Get2`) and endpoints requiring a Bearer token (`Get`).
- **OpenAPI Configuration**: Swagger prepared to test the JWT token in the Authorization header.

## Endpoints

| Method | Route | Description | Security |
| --- | --- | --- | --- |
| `GET` | `/api/v1/home/Get` | Example protected endpoint | **Required** |
| `GET` | `/api/v1/home/Get2` | Example public endpoint | Open |
| `POST` | `/api/v1/auth/login` | Obtains a JWT token | Open |

## Authentication

A **JwtBearer** scheme is used with issuer, audience, and symmetric key validation. The generated token is valid for 3 hours.

> **Security Note**: This is a proof-of-concept ("POC") implementation. The secret is stored directly in the code for simplicity and must not be used in production.

## How to test

1.  **Login**: Send a POST to `/api/v1/auth/login` with `{ "username": "admin", "password": "password" }`.
2.  **Use the Token**: Copy the received `token` and add it as a Bearer token in your Swagger client or testing tool.
3.  **Access**: Call `/api/v1/home/Get` to confirm valid authorization.