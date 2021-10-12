# metricas-logs
Monitoramento de métricas e centralização de logs em aplicações .NET Core

<img src="https://github.com/GlerystonMatos/metricas-logs/blob/main/openAPM-Landscape.png" />

Para criar o ambiente com docker execute o comando a seguir em um console na pasta do arquivo docker-compose.yaml:

```bash
docker-compose up -d
```
Aplicação WEB: 

```bash
https://localhost:8081/WeatherForecast
```

```bash
https://localhost:8081/Log/Information
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