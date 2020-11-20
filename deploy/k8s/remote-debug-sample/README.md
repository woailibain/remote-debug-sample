### Access app through Ingress
1. create deployment
```kubectl create -f deployment.yaml```

2. add service to map the Pod
```kubectl create -f service.yaml```

3. add Ingress to access the Services externally
```kubectl create -f ingress.yaml```

4. to see is the Ingress can touch Service
```kubectl describe ingress remote-debug-sample-ingress```
