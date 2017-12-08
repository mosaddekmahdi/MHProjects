package org.arpit.javapostforlearning.webservices;

public class HiThereProxy implements org.arpit.javapostforlearning.webservices.HiThere {
  private String _endpoint = null;
  private org.arpit.javapostforlearning.webservices.HiThere hiThere = null;
  
  public HiThereProxy() {
    _initHiThereProxy();
  }
  
  public HiThereProxy(String endpoint) {
    _endpoint = endpoint;
    _initHiThereProxy();
  }
  
  private void _initHiThereProxy() {
    try {
      hiThere = (new org.arpit.javapostforlearning.webservices.HiThereServiceLocator()).getHiThere();
      if (hiThere != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)hiThere)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)hiThere)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (hiThere != null)
      ((javax.xml.rpc.Stub)hiThere)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.arpit.javapostforlearning.webservices.HiThere getHiThere() {
    if (hiThere == null)
      _initHiThereProxy();
    return hiThere;
  }
  
  public java.lang.String sayHiThere(java.lang.String name) throws java.rmi.RemoteException{
    if (hiThere == null)
      _initHiThereProxy();
    return hiThere.sayHiThere(name);
  }
  
  
}