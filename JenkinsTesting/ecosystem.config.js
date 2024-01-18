module.exports = {
    apps: [{
        name: "JenkinsTesting",
        script: "dotnet JenkinsTesting.dll --urls http://192.168.1.40:5005"
    }]
}