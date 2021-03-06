﻿using PruebaNet.Datos.Base;
using PruebaNet.Datos.DTO;
using PruebaNet.Datos.Proyection;
using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Datos.Repositories
{
    public class ClientsRepository : IClient
    {
        IBaseRepository<PruebaNet.Datos.EntitiesTable.Client> _clientTable;
        public ClientsRepository(IBaseRepository<PruebaNet.Datos.EntitiesTable.Client> _client)
        {
            _clientTable = _client;
        }

        public async Task<Result<bool>> Create(Client client)
        {

            Result<bool> resp = new Result<bool>();
            try
            {
                EntitiesTable.Client clientTable = CastClientToClientTable(client);

                await _clientTable.Insert(clientTable);
                resp.IsSuccess = true;
                resp.Response = true;

            }
            catch (Exception ex)
            {
                resp.IsSuccess = false;
                resp.Response = false;
                resp.Exception = $"Ocurrio un error al crear el usuario {ex.Message}";
            }

            return resp;
        }

        public async Task<Result<bool>> Delete(Client client)
        {
            Result<bool> resp = new Result<bool>();
            try
            {
                EntitiesTable.Client clientTable = CastClientToClientTable(client);

                await _clientTable.Delete(clientTable);
                resp.IsSuccess = true;
                resp.Response = true;

            }
            catch (Exception ex)
            {
                string exceptionText = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.ToString();
                resp.IsSuccess = false;
                resp.Exception = $"Ocurrio un error consultando los cliente: {  exceptionText }";
            }

            return resp;
        }

        public async Task<Result<IEnumerable<Client>>> Get()
        {

            Result<IEnumerable<Client>> resp = new Result<IEnumerable<Client>>();
            List<Client> listClient = new List<Client>();
            try
            {
                var result = _clientTable.GetAll();

                foreach (var item in result)
                {
                    Client clientGet = new Client(item.Identification, item.Name, item.Email, item.PhoneNumber, item.Addres, item.City);
                    clientGet.id = item.Id;
                    listClient.Add(clientGet);
                }

                resp.IsSuccess = true;
                resp.Response = listClient;
            }
            catch (Exception ex)
            {
                string exceptionText = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.ToString();
                resp.IsSuccess = false;
                resp.Exception = $"Ocurrio un error consultando los cliente: {  exceptionText }";
            }
            return resp;
        }

        public async Task<Result<Client>> Get(int clientId)
        {
            Result<Client> resp = new Result<Client>();
            try {

                EntitiesTable.Client clientTable = await _clientTable.Get(Convert.ToInt64(clientId));
                resp.Response = CastClientTableToClient(clientTable);
                resp.IsSuccess = true;

            } catch(Exception ex)
            {
                string exceptionText = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.ToString();
                resp.IsSuccess = false;
                resp.Exception = $"Ocurrio un error consultando los cliente: {  exceptionText }";
            }
            throw new NotImplementedException();
        }

        public async Task<Result<bool>> Update(Client client)
        {
            Result<bool> resp = new Result<bool>();
            try
            {
                EntitiesTable.Client clientTable = CastClientToClientTable(client);

                await _clientTable.Update(clientTable);
                resp.IsSuccess = true;
                resp.Response = true;

            }
            catch (Exception ex)
            {
                string exceptionText = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.ToString();
                resp.IsSuccess = false;
                resp.Exception = $"Ocurrio un error consultando los cliente: {  exceptionText }";
            }

            return resp;
        }

        private static EntitiesTable.Client CastClientToClientTable(Client client)
        {
            EntitiesTable.Client clientTable = new EntitiesTable.Client();

            clientTable.ModifiedDate = DateTime.Now;
            clientTable.AddedDate = DateTime.Now;
            clientTable.Identification = Convert.ToInt32(client.identification);
            clientTable.Name = client.name;
            clientTable.PhoneNumber = client.phoneNumber;
            clientTable.Email = client.email;
            clientTable.Addres = client.addres;
            clientTable.City = client.city;
            return clientTable;
        }

        private static Client CastClientTableToClient(EntitiesTable.Client clientTable)
        {
            Client client = new Client(clientTable.Identification, clientTable.Name, clientTable.Email, clientTable.PhoneNumber, clientTable.Addres, clientTable.City);
            client.id = clientTable.Id;
            return client;
        }
    }
}
