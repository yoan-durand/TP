/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package com.mti.webcxf;

import Interface.MTIPeopleInterface;
import java.util.List;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.EntityManager;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.PersistenceContext;
import javax.persistence.Table;

/**
 *
 * @author durand_y
 */

@Entity
@Table
public class MTIPeople 
{
    
    private int id;
    private String login;
    private String lastName;
    private String firstName;

    @Column
    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    @Id
    @GeneratedValue
    @Column
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    @Column
    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    @Column
    public String getLogin() {
        return login;
    }

    public void setLogin(String Login) {
        this.login = Login;
    }   
}
