pipeline {
    agent any
 
    stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/DivyanshuDilip/BDDFrameworkRepo.git', branch: 'BDDFrameworkProject'
            }
        }
 
        stage('Restore') {
            steps {
                dir('MyNUnitProject') {
                    sh 'dotnet restore'
                }
            }
        }
 
        stage('Build') {
            steps {
                dir('MyNUnitProject') {
                    sh 'dotnet build --configuration Release'
                }
            }
        }
 
        stage('Test') {
            steps {
                dir('MyNUnitProject') {
                    sh 'dotnet test --logger "trx;LogFileName=test_results.trx"'
                }
            }
        }
 
        stage('Publish Test Results') {
            steps {
                echo 'Note: TRX format not supported by junit step. Convert to XML if needed.'
            }
        }
    }
}