# Instructions
using minikub and docker, helm

```bash
NAMESPACE="arc-runners"
helm install arc \
    --namespace "${NAMESPACE}" \
    --create-namespace \
    oci://ghcr.io/actions/actions-runner-controller-charts/gha-runner-scale-set-controller
```
```
NAMESPACE="arc-systems"
helm install arc \
    --namespace "${NAMESPACE}" \
    --create-namespace \
    oci://ghcr.io/actions/actions-runner-controller-charts/gha-runner-scale-set-controller

INSTALLATION_NAME="arc-runner-set"
GITHUB_CONFIG_URL="https://github.com/connorleekite01/actions-runner-controller"
GITHUB_PAT="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"
helm install "${INSTALLATION_NAME}" \
    --namespace "${NAMESPACE}" \
    --create-namespace \
    --set githubConfigUrl="${GITHUB_CONFIG_URL}" \
    --set githubConfigSecret.github_token="${GITHUB_PAT}" \
    oci://ghcr.io/actions/actions-runner-controller-charts/gha-runner-scale-set
```

```
INSTALLATION_NAME="arc"
NAMESPACE="arc-runners"
helm uninstall "${INSTALLATION_NAME}" --namespace "${NAMESPACE}"

INSTALLATION_NAME="arc-runners-set"
NAMESPACE="arc-runners"
helm uninstall "${INSTALLATION_NAME}" --namespace "${NAMESPACE}"
```


```bash
docker ps
```

```bash
helm list -n "${NAMESPACE}"
```
