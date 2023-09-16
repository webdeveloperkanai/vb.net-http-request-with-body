Using httpClient As New HttpClient()

            ' Define the data to be sent
            Dim requestData As New Dictionary(Of String, String)()
            requestData.Add("uid", GLobalData.uid)
            requestData.Add("uid", GLobalData.company)
            requestData.Add("branch", GLobalData.branch)
            requestData.Add("cid", GLobalData.cid)
            requestData.Add("bid", GLobalData.cid)
            requestData.Add("name", "John Doe")

            requestData.Add("email", "john.doe@example.com")
            requestData.Add("phone", "123-456-7890")
            requestData.Add("photo", "base64-encoded-photo-data")
            requestData.Add("signature", "base64-encoded-signature-data")
            requestData.Add("registerMember", "base64-encoded-signature-data")

            ' Convert the data to JSON (if your API expects JSON data)
            Dim jsonContent As String = Newtonsoft.Json.JsonConvert.SerializeObject(requestData)

            ' Create a StringContent with the JSON data
            Dim content As New StringContent(jsonContent, Encoding.UTF8, "application/text")

            ' Send the POST request to the API
            Dim response As HttpResponseMessage = Await httpClient.PutAsync(GLobalData.APP_API, content)

            ' Check the response status code
            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Data successfully posted. Response: " & responseContent)
            Else
                MessageBox.Show("Error: " & response.StatusCode.ToString())
            End If
        End Using
