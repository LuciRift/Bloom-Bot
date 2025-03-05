
// This example demonstrates how to send a license request to the License Server

package main

import (
	"fmt"
	"io/ioutil"
	"net/http"
	"strings"
)

func main() {
	url := "http://<your_ip>:<port>/api/client"
	apiKey := "API_KEY"
	license := "<LICENSE>"
	product := "<PRODUCT>"
	version := "<VERSION>"

	data := strings.NewReader(fmt.Sprintf("license=%s&product=%s&version=%s", license, product, version))

	req, err := http.NewRequest("POST", url, data)
	if err != nil {
		panic(err)
	}

	req.Header.Add("Authorization", apiKey)
	req.Header.Add("Content-Type", "application/x-www-form-urlencoded")

	client := &http.Client{}
	resp, err := client.Do(req)
	if err != nil {
		panic(err)
	}
	defer resp.Body.Close()

	body, err := ioutil.ReadAll(resp.Body)
	if err != nil {
		panic(err)
	}

	fmt.Println(string(body))
}

// To send the IP and HWID to the server

package main

import (
	"fmt"
	"io/ioutil"
	"net/http"
	"strings"
)

func main() {
	url := "http://<your_ip>:<port>/api/client"
	apiKey := "API_KEY"
	license := "<LICENSE>"
	product := "<PRODUCT>"
	version := "<VERSION>"
	ip := "<IP>"
	hwid := "<HWID>"

	data := strings.NewReader(fmt.Sprintf("license=%s&product=%s&version=%s&ip=%s&hwid=%s", license, product, version, ip, hwid))

	req, err := http.NewRequest("POST", url, data)
	if err != nil {
		panic(err)
	}

	req.Header.Add("Authorization", apiKey)
	req.Header.Add("Content-Type", "application/x-www-form-urlencoded")

	client := &http.Client{}
	resp, err := client.Do(req)
	if err != nil {
		panic(err)
	}
	defer resp.Body.Close()

	body, err := ioutil.ReadAll(resp.Body)
	if err != nil {
		panic(err)
	}

	fmt.Println(string(body))
}
