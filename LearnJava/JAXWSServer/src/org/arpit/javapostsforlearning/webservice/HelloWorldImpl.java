package org.arpit.javapostsforlearning.webservice;

import javax.jws.WebService;

@WebService(endpointInterface="org.arpit.javapostsforlearning.webservice.HelloWorld")
public class HelloWorldImpl {

	public String helloWorld(String name){
		return "A JAX-WS Hello world from " + name;
	}
}
