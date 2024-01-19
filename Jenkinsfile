pipeline {
    agent prodigy-commissary-dev

    stages {
        stage('Build') {
            steps {
                cd JenkinsTesting
                dotnet build
                echo '{"where":"QA"}' | jq . > appsettings.QA.json
                dotnet publish -c QA -r linux-x64 --self-contained true 
            }
        }
        stage('Deploy') {
            steps {
                mkdir -p /home/jenkins/fuzzy-funicular
                cp ./JenkinsTesting/bin/QA/net6.0/publish /home/jenkins/fuzzy-funicular
            }
        }
    }
}