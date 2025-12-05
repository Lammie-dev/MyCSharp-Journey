const express = require("express");
const swaggerUi = require("swagger-ui-express");
const swaggerJsdoc = require("swagger-jsdoc");

const app = express();
app.use(express.json());

// ----------------------
// Swagger setup
// ----------------------
const swaggerOptions = {
  definition: {
    openapi: "3.0.0",
    info: {
      title: "My API (Swagger-JSDoc Version)",
      version: "1.0.0",
      description: "Example API documentation using swagger-jsdoc",
    },
    servers: [{ url: "http://localhost:3000" }],
  },
  apis: ["./server.js"], // 👈 scans this file for @swagger comments
};

const swaggerSpec = swaggerJsdoc(swaggerOptions);
app.use("/api-docs", swaggerUi.serve, swaggerUi.setup(swaggerSpec));

// ----------------------
// Default home route
// ----------------------
app.get("/", (req, res) => {
  res.send(`
    <h1>🚀 Welcome to My API</h1>
    <p>Visit <a href="/api-docs">/api-docs</a> to view Swagger documentation.</p>
  `);
});

// ----------------------
// Example API routes
// ----------------------

/**
 * @swagger
 * /hello:
 *   get:
 *     summary: Get a greeting
 *     responses:
 *       200:
 *         description: Success
 */
app.get("/hello", (req, res) => {
  res.json({ message: "Hello World!" });
});

/**
 * @swagger
 * /add:
 *   post:
 *     summary: Add two numbers
 *     requestBody:
 *       required: true
 *       content:
 *         application/json:
 *           schema:
 *             type: object
 *             properties:
 *               a:
 *                 type: number
 *               b:
 *                 type: number
 *     responses:
 *       200:
 *         description: Returns the sum
 */
app.post("/add", (req, res) => {
  const { a, b } = req.body;
  res.json({ result: a + b });
});

// ----------------------
// Start the server
// ----------------------
app.listen(3000, () => {
  console.log("🚀 Server running at http://localhost:3000");
  console.log("📄 Swagger docs available at http://localhost:3000/api-docs");
});
