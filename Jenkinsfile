pipeline {
    agent prodigy-commissary-dev

    stages {
        stage('Build') {
            steps {
                sh '
                    cd JenkinsTesting
                    dotnet build
                '
            }
        }
    }
}