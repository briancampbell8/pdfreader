// pages/api/redirect.js
export default function handler(req, res) {
  const { code } = req.query;
  if (code) {
    res.status(200).send(`Redirect successful. Code received: ${code}`);
  } else {
    res.status(400).send('No code provided.');
  }
}
