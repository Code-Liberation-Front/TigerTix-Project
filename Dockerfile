FROM ubuntu:latest

# Adding Labels to identify repository for github
LABEL org.opencontainers.image.source="https://github.com/Code-Liberation-Front/TigerTix-Project"
LABEL org.opencontainers.image.description="Containerized Version of TigerTix"

RUN apt update
RUN apt install libicu-dev -y
RUN apt upgrade

# Set work directory, copy source code to there
WORKDIR /app
COPY app .

# Run the ASP.NET application
CMD [ "./TigerTix.Web" ]