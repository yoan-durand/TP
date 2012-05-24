/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package com.mti.webcxf;

import Interface.HelloWorld;
import javax.jws.WebService;


/**
 *
 * @author yoan
 */
@WebService(serviceName = "HelloWord", endpointInterface= "Interface.HelloWorld" )
public class HelloWorldImpl implements HelloWorld
{

    /**
     * This is a sample web service operation
     */
    @Override
    public String HelloWorld(String name) 
    {
         return "Hello " + name + " !";
        
    }
}
