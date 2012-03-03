package com.mti.sample;

import com.mti.sample.HelloWorld;
import org.springframework.beans.factory.xml.XmlBeanFactory;
import org.springframework.core.io.ClassPathResource;

/**
 * Hello world!
 *
 */
public class App 
{
    private static XmlBeanFactory factory;
    public static void main( String[] args )
    {
        
       ClassPathResource res = new ClassPathResource("applicationContext.xml");
       factory = new XmlBeanFactory(res);
       HelloWorld h = (HelloWorld) factory.getBean("hello");
       h.print();

    }
}
