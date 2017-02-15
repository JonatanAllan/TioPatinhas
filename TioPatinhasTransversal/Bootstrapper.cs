﻿using SimpleInjector;
using TioPatinhasAplicacao.Interfaces.ServicosApp;
using TioPatinhasAplicacao.ServicosApp;
using TioPatinhasDados.Repositorios;
using TioPatinhasDominio.Interfaces.Repositorios;
using TioPatinhasDominio.Interfaces.Servicos;
using TioPatinhasDominio.Servicos;
using TioPatinhasRecursos.Interfaces.ServicosExternos;
using TioPatinhasRecursos.ServicosExternos;
using TioPatinhasTarefa.Interfaces.Tarefas;
using TioPatinhasTarefa.Tarefas;

namespace TioPatinhasTransversal
{
    public class Bootstrapper
    {
        public static void RegisterServices(Container container)
        {
            // Crons
            container.Register<IExemploTarefa, ExemploTarefa>(Lifestyle.Scoped);

            // Recursos
            container.Register<IExemploServicosExternos, ExemploServicosExternos>(Lifestyle.Scoped);

            // Aplicacao
            container.Register<IExemploServicosApp, ExemploServicosApp>(Lifestyle.Scoped);

            // Dominio
            container.Register<IExemploServicos, ExemploServicos>(Lifestyle.Scoped);

            // Infra
            container.Register<IExemploRepositorio, ExemploRepositorio>(Lifestyle.Scoped);
        }
    }
}