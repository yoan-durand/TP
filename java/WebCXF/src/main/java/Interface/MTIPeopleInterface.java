/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Interface;

import com.mti.webcxf.MTIPeople;
import java.util.List;

/**
 *
 * @author yoan
 */
public interface MTIPeopleInterface
{
    public void persist(MTIPeople people);
    
    public void remove(MTIPeople people);
    
    public void merge(MTIPeople people);
    
    public List<MTIPeople> findAll();
    
    public MTIPeople findByLogin(String login);
}
