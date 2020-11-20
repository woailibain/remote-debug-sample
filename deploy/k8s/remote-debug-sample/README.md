1. create Pod on Kubernetes
```kubectl create -f deploy.yaml```

2. get Pod status on Kubernetes
```kubectl get pods```

3. forward ports from local to Kubernetes pod
```kubectl port-forward remote-debug-sample 5000:5000```