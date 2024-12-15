// src/routes/[your-route]/+server.ts
import type { RequestHandler } from './$types';

export const GET: RequestHandler = async () => {
  try {
    const response = await fetch("https://jsonplaceholder.typicode.com/todos/1");

    if (!response.ok) {
      // Caso a API retorne um erro, lidamos com isso
      return new Response(JSON.stringify({ error: "Failed to fetch data" }), { 
        status: 500 
      });
    }

    const data = await response.json();

    // Retorna os dados como JSON
    return new Response(JSON.stringify(data), { 
      status: 200, 
      headers: { 'Content-Type': 'application/json' } 
    });

  } catch (error) {
    // Lida com erros de rede ou outros problemas
    return new Response(JSON.stringify({ error: "Something went wrong" }), { 
      status: 500 
    });
  }
};


export const POST: RequestHandler = async () => {
  return new Response("Hello world");
};

export const DELETE: RequestHandler = async () => {
  return new Response("Hello world");
};

export const PUT: RequestHandler = async () => {
  return new Response("Hello world");
};