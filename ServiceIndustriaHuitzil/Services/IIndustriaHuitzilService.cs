﻿using CoreIndustriaHuitzil.Models;
using CoreIndustriaHuitzil.ModelsRequest;
using CoreIndustriaHuitzil.ModelsResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceIndustriaHuitzil.Services
{
    public interface IIndustriaHuitzilService
    {
        #region Auth
        Task<ResponseModel> auth(AuthUserRequest usuario);
        #endregion

        #region Apartados
        Task<ResponseModel> getApartados();
        Task<ResponseModel> getApartadosByUbicacion(string ubicacion);
        Task<ResponseModel> getArticulosApartado(int idApartado);
        Task<ResponseModel> getApartadosByUser(int IdUsuario, string type, int IdApartado);
        Task<ResponseModel> postApartados(ApartadosRequest apartadosRequest);
        Task<ResponseModel> putApartados(ApartadosRequest apartadosRequest);
        Task<ResponseModel> deleteApartados(ApartadosRequest apartadosRequest);

        #endregion
        #region Caja
        Task<ResponseModel> getCajaDate(string sucursal);
        Task<ResponseModel> getCajaDate(DateTime dateI, DateTime dateF, string sucursal);
        Task<ResponseModel> getCaja(int idUser);
        Task<ResponseModel> openCaja(CajaRequest request);
        Task<ResponseModel> closeCaja(CajaRequest request);
        #endregion

        #region Cambios y Devoluciones
        Task<ResponseModel> searchVentaByNoTicket(string noTicket);
        Task<ResponseModel> getCambiosyDevoluciones();
        Task<ResponseModel> postCambiosyDevoluciones(CambiosDevolucionesRequest cambiosDevoluciones);
        #endregion

        #region Clientes
        Task<ResponseModel> getClientes();
        Task<ResponseModel> getClientesbySucursal(string sucursal);
        Task<ResponseModel> postCliente(ClienteRequest cliente);
        Task<ResponseModel> putCliente(ClienteRequest cliente);
        Task<ResponseModel> deleteCliente(ClienteRequest cliente);
        #endregion

        #region Dashboard
        Task<ResponseModel> getCards(string year, int idSucursal);
        Task<ResponseModel> getVentasPorMes(string year, int idSucursal);
        Task<ResponseModel> getRankingArticulos(string year, int idSucursal);
        Task<ResponseModel> getRankingEmpleados(string year, int idSucursal);
        Task<ResponseModel> getRankingSucursales(string year);
        #endregion

        #region Materiales
        Task<ResponseModel> getMateriales();
        Task<ResponseModel> postMaterial(MaterialRequest material);
        Task<ResponseModel> putMaterial(MaterialRequest material);
        Task<ResponseModel> deleteMaterial(MaterialRequest material);
        #endregion

        #region MaterialesUbicaciones
        Task<ResponseModel> getMaterialesUbicaciones();
        #endregion

        #region PagoApartados
        Task<ResponseModel> getPagos();
        Task<ResponseModel> getPagosByApartado(int IdApartado);
        Task<ResponseModel> getPagosByCaja(int IdCaja);
        Task<ResponseModel> postPagoApartado(PagoApartadoRequest pagoApartadoRequest);
        Task<ResponseModel> deletePagoApartado(PagoApartadoRequest pagoApartadoRequest);

        #endregion
        #region Proveedores
        Task<ResponseModel> getProveedores();
        Task<ResponseModel> postProveedor(ProveedorRequest proveedor);
        Task<ResponseModel> putProveedor(ProveedorRequest proveedor);
        Task<ResponseModel> deleteProveedor(ProveedorRequest proveedor);

        Task<ResponseModel> searchCliente(string queryString);
        #endregion

        #region Productos
        Task<ResponseModel> getProductos(string sucursal);
        Task<ResponseModel> getInexistencias(string sucursal);
        Task<ResponseModel> postProductos(ProductoRequest producto);
        Task<ResponseModel> putProductos(ProductoRequest producto);
        Task<ResponseModel> deleteProductos(ProductoRequest producto);

        Task<ResponseModel> searchProduct(string queryString, string sucursal);

        Task<ResponseModel> SearchProductDemanda(SearchProductFilters searchProductFilters);
        
        Task<ResponseModel> SearchProductFilterUbicacion( string sucursal);
        
        #endregion

        #region ProveedoresMateriales
        Task<ResponseModel> getProveedoresMateriales();
        #endregion

        #region Roles
        Task<ResponseModel> getRoles();
        Task<ResponseModel> postRol(RolRequest rol);
        Task<ResponseModel> putRol(RolRequest rol);
        Task<ResponseModel> deleteRol(RolRequest rol);
        Task<ResponseModel> correo(CorreoRequest correo);
        Task<ResponseModel> correoOrion(CorreoRequest correo);
        #endregion

        #region SolicitudMaterial
        Task<ResponseModel> getSolicitudesMateriales();
        Task<ResponseModel> postSolicitudMaterial(SolicitudesMaterialesRequest material);
        Task<ResponseModel> putSolicitudMaterial(SolicitudesMaterialesRequest material);
        Task<ResponseModel> deleteSolicitudMaterial(SolicitudesMaterialesRequest material);
        #endregion

        #region Tallas
        Task<ResponseModel> getTallas();
        Task<ResponseModel> postTalla(TallaRequest talla);
        Task<ResponseModel> putTalla(TallaRequest talla);
        Task<ResponseModel> deleteTalla(TallaRequest talla);
        #endregion

        #region Ubicaciones
        Task<ResponseModel> getUbicaciones();
        Task<ResponseModel> postUbicacion(UbicacionRequest ubicacionRequest);
        Task<ResponseModel> putUbicacion(UbicacionRequest ubicacionRequest);
        Task<ResponseModel> deleteUbicacion(UbicacionRequest ubicacionRequest);

        #endregion

        #region Categorias
        Task<ResponseModel> getCategorias();
        Task<ResponseModel> postCategoria(CategoriaRequest categoriaRequest);
        Task<ResponseModel> putCategoria(CategoriaRequest categoriaRequest);
        Task<ResponseModel> deleteCategoria(CategoriaRequest categoriaRequest);

        #endregion

        #region Usuarios
        Task<ResponseModel> getUsuarios();
        Task<ResponseModel> postUsuario(UsuarioRequest usuario);
        Task<ResponseModel> putUsuario(UsuarioRequest usuario);
        Task<ResponseModel> deleteUsuario(UsuarioRequest usuario);
        Task<ResponseModel> updatePassword(int idUsuario, string newPassword);
        #endregion

        #region Vistas
        Task<ResponseModel> getVistas();
        #endregion

        #region VistasRoles
        Task<ResponseModel> getVistasRol(int idRol);
        Task<ResponseModel> postVistaRol(VistaRolRequest vistaRol);
        Task<ResponseModel> putVistaRol(VistaRolRequest vistaRol);
        Task<ResponseModel> deleteVistaRol(VistaRolRequest vistasRol);
        #endregion

        #region Ventas 
        //Task<ResponseModel> searchVentaByNoTicket(string noTicket);
        //Task<ResponseModel> getCambiosyDevoluciones();
        Task<ResponseModel> postCancelacionVenta(CambiosDevolucionesRequest request);
        Task<ResponseModel> postAddVentas(VentaRequest venta);
        Task<ResponseModel> getVentas();
        Task<ResponseModel> getVentasByDates(DateTime dateI , DateTime dateF);
        Task<ResponseModel> getVentasByCaja(int idCaja);
        //Task<ResponseModel> putCambiosyDevoluciones(CambiosDevolucionesRequest cambiosDevoluciones);
        #endregion

        #region Movimientos
        Task<ResponseModel> getMovimientos();
        Task<ResponseModel> getMovimientosArticulos();

        Task<ResponseModel> addMovimientoInventario(MovimientoInvetarioRequest request);

        Task<ResponseModel> updateConteo(MovimientoInvetarioRequest request);
        Task<ResponseModel> updateMovimientoInventario(MovimientoInvetarioRequest request);
 



        #endregion


    }
}
