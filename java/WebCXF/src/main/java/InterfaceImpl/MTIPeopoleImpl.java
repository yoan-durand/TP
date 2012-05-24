/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package InterfaceImpl;

import Interface.MTIPeopleInterface;
import com.mti.webcxf.MTIPeople;
import java.util.List;
import javax.persistence.Entity;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

/**
 *
 * @author yoan
 */
public class MTIPeopoleImpl implements MTIPeopleInterface
{
    @PersistenceContext private EntityManager entity;
    
    
    @Override
    public void persist(MTIPeople people) 
    {
        entity.persist(people);
    }

    @Override
    public void remove(MTIPeople people) 
    {
        entity.remove(people);
    }

    @Override
    public void merge(MTIPeople people)
    {
        entity.merge(people);
    }

    @Override
    public List<MTIPeople> findAll() {
    }

    @Override
    public MTIPeople findByLogin(String login) {
        throw new UnsupportedOperationException("Not supported yet.");
    }
    
}
