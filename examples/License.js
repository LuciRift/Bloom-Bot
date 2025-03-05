import axios from "axios";


// This example demonstrates how to send a license request to the License Server
async function checkLicense(license, product, version) {
	const URL = "http://<your_ip>:<port>/api/client";
	const API_KEY = "API_KEY";

	const res = await axios.post(
		URL,
		{
			license,
			product,
			version,
		},
		{ headers: { Authorization: API_KEY } }
	).catch(e => e);

	if (res.data?.status_overview !== "success" && res.data?.status_code !== 200) {
		return false;
	}

	return res.data;
}

// To send the IP and HWID to the server

async function checkLicense(license, product, version, ip, hwid) {
	const URL = "http://<your_ip>:<port>/api/client";
	const API_KEY = "API_KEY";

	const res = await axios.post(
		URL,
		{
			license,
			product,
			version,
			ip,
			hwid,
		},
		{ headers: { Authorization: API_KEY } }
	).catch(e => e);

	if (res.data?.status_overview !== "success" && res.data?.status_code !== 200) {
		return false;
	}

	return res.data;
}

export default checkLicense;