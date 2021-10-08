# prometheus-net
Monitoramento de aplicações .NET Core com Prometheus

Para criar o ambiente com docker execute o comando a seguir em um console na pasta do arquivo docker-compose.yaml:

```bash
docker-compose up -d
```
Aplicação WEB: 

```bash
https://localhost:8081/WeatherForecast
```

Metricas da aplicação WEB:

```bash
https://localhost:8081/metrics
```

Prometheus:

```bash
http://localhost:9090/targets
```

Promtail:

```bash
http://localhost:9080/targets
```

Grafana:

```bash
http://localhost:3000/
```

<a href="https://www.linkedin.com/in/glerystonmatos/" target="_blank">Gleryston Matos</a><br/>
glerystonmatos@yahoo.com.br<br/>
glerystonmatos@gmail.com<br/>