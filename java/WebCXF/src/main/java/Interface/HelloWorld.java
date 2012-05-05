/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Interface;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;

/**
 *
 * @author yoan
 */

@WebService
@Path("/")
public interface HelloWorld 
{
    @WebMethod
    @GET
    @Path("/hello/{name}")
    public String HelloWorld(@WebParam (name="name") @PathParam("name") String name);
}
