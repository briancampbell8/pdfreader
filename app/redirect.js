// Use ES module export since Vercel supports it by default.
export default function handler(req, res) {
    // Extract the "code" query parameter from the request
    const { code } = req.query;

    // In a production scenario, if needed, you can exchange the code for an access token here.
    // For now, we simply respond with a confirmation message.
    if (code) {
        res.status(200).send(`Redirect successful. Code received: ${code}`);
    } else {
        res.status(400).send('No code provided.');
    }
}
// JavaScript source code
