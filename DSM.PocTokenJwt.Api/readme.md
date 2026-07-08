# POC Token JWT API

Esta es una API demo que demuestra el flujo de **Authentication JWT** en ASP.NET Core: generación de tokens en el controlador de autenticación y validación automática en las rutas protegidas.

## Funcionalidades

- **Login JWT**: Endpoint que valida credenciales y devuelve un token firmado con HMAC SHA256.
- **Rutas protegidas y abiertas**: Ejemplos de endpoints públicos (`Get2`) y endpoints que requieren Bearer token (`Get`).
- **Configuración OpenAPI**: Swagger preparado para probar el token JWT en el header Authorization.

## Endpoints

| Método | Ruta | Descripción | Seguridad |
| --- | --- | --- | --- |
| `GET` | `/api/v1/home/Get` | Endpoint de ejemplo protegido | **Required** |
| `GET` | `/api/v1/home/Get2` | Endpoint de ejemplo público | Open |
| `POST` | `/api/v1/auth/login` | Obtiene un token JWT | Open |

## Autenticación

Se utiliza un esquema **JwtBearer** con validación de emisor, audiencia y clave simétrica. El token generado tiene una validez de 3 horas.

> **Nota de seguridad**: Esta es una implementación de prueba ("POC"). El secreto se guarda directamente en el código por simplicidad y no debe usarse en producción.

## Cómo probarlo

1.  **Loguearse**: Envía un POST a `/api/v1/auth/login` con `{ "username": "admin", "password": "password" }`.
2.  **Usar el Token**: Copia el `token` recibido y añádelo como Bearer en tu cliente Swagger o herramienta de pruebas.
3.  **Acceder**: Llama a `/api/v1/home/Get` para confirmar la autorización válida.