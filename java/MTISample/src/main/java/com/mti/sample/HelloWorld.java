/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
        
package com.mti.sample;

import com.mti.webcxf.MTIPeople;

/**
 *
 * @author durand_y
 */


public class HelloWorld 
{
    private MTIPeople people;

    public MTIPeople getPeople() 
    {
        return people;
    }

    public void setPeople(MTIPeople people) 
    {
        this.people = people;
    }
    
    
    public String helloWorld()
    {
        String str = "Hello ";
        if (people == null)
            str += "World !";
        else
        {
            str += people.getFullName();
            str += " !";
        }
        return (str);
    }
    
    public void print ()
    {
        System.out.println(people.getLogin()+" "+people.getFullName());
    }
    
}
