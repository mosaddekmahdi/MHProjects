package com.mkyong.ws;

import javax.jws.WebMethod;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;
import javax.jws.soap.SOAPBinding.Style;


// service endpoint interface
@WebService
@SOAPBinding(style = Style.RPC)
public interface HelloWorld {

	@WebMethod String getHelloWorldAsString(String name);
}
