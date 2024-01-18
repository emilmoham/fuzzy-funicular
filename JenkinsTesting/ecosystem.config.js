module.exports = {
    apps: [{
        name: "JenkinsTesting",
        script: "ASPNETCORE_ENVIRONMENT=QA dotnet JenkinsTesting.dll --urls http://192.168.1.40:5005"
    }]
}