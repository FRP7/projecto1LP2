﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace projeto1LP2
{
    /// <summary>
    /// Classe onde vão estar os métodos de pesquisa de estrelas.
    /// </summary>
    class StarSearcher 
    {
        // Aceder à Facade.
        private Facade facade;
        // Estas variáveis têem obrigatoriamente de serem inicializadas aqui!
        private Dictionary<int, Star> filterByName = new Dictionary<int, Star>(Facade.starList);
        private Dictionary<int, Star> filterByDiscoveryMethod = new Dictionary<int, Star>(Facade.starList);
        private Dictionary<int, Star> filterByDiscoveryYear = new Dictionary<int, Star>(Facade.starList);

        // Método de pesquisa de estrelas pelo nome.
        public void SearchByName(string input) {
            Facade.starList = filterByName; // obrigatório!!!!

            Console.WriteLine("Filtrar pelo nome");

            filterByName =
                (from item in filterByName
                 where item.Value.HostName.StartsWith(input)
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByName) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Planets: {item.Value.St_PlCount,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        // Método de pesquisa de estrelas pelo método de descoberta.
        public void SearchByDiscoveryMethod(string input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pelo método de descoberta");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.DiscoveryMethod.StartsWith(input)
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Discovery method: {item.Value.DiscoveryMethod,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByDiscoveryYear(int input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pelo ano de descoberta");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.Disc_Year == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Discovery year: {item.Value.Disc_Year,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByTeff(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pela temperatura");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.St_Teff == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Temperature: {item.Value.St_Teff,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByRad(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pelo raio");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.St_Rad == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Radius: {item.Value.St_Rad,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByMass(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pela massa");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.St_Mass == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Mass: {item.Value.St_Mass,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByAge(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pela idade");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.St_Age == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Age: {item.Value.St_Age,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByVsin(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pela velocidade de rotação");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.St_Vsin == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Rotation velocity: {item.Value.St_Vsin,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByRotp(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pelo período de rotação");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.St_Rotp == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Rotation period: {item.Value.St_Rotp,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByDist(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pela distância");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.Sy_Dist == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Distance: {item.Value.Sy_Dist,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        public void SearchByPlCount(double input) {
            Facade.starList = filterByDiscoveryMethod; // obrigatório!!!!

            Console.WriteLine("Filtrar pelo número de planetas");

            filterByDiscoveryMethod =
                (from item in filterByDiscoveryMethod
                 where item.Value.St_PlCount == input
                 select item).ToDictionary(p => p.Key, p => p.Value);

            // Imprimir
            foreach (KeyValuePair<int, Star> item in filterByDiscoveryMethod) {
                Console.WriteLine(string.Format($"ID: " +
                    $"{item.Key,-5} | Star: {item.Value.HostName,-30}" +
                 $" | Planet count: {item.Value.St_PlCount,-2}"));
            }
            Console.WriteLine("Dicionário filtro: " + filterByName.Count);
        }

        // Inicializar as variáveis.
        public StarSearcher() {
            facade = new Facade();
        }
    }
}
