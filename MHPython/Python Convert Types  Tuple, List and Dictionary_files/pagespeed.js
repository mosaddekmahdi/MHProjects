window.ozoki_os = 'post.update.spotxchange.com'; window.ozoki_ct = {"ci":"sp99","pi":"http://www.dotnetperls.com/convert-python","ac":"1787650","ti":"e572291fea57af864525280042a4f87e","pp":"79862"};(function() {
  var check_for_sc, conservative, console, ct, getRandom, get_sc_last_resort, get_sc_remote, getdest, go_on, now, nowdf, os, postdest, proto, sc, sc_checked, sos, start, worked;



  if (window.ozoki_loaded === true || (window.ozoki_sc != null)) {
    return;
  }

  window.ozoki_loaded = true;

  console = console || window.console;

  if (typeof console === 'undefined') {
    console = {};
    console.log = function(x) {};
  }

  if (1) {
    /*!  SWFObject v2.2 <http://code.google.com/p/swfobject/> 
  is released under the MIT License <http://www.opensource.org/licenses/mit-license.php> 
*/

var swfobject = function() {
  
  var UNDEF = "undefined",
    OBJECT = "object",
    SHOCKWAVE_FLASH = "Shockwave Flash",
    SHOCKWAVE_FLASH_AX = "ShockwaveFlash.ShockwaveFlash",
    FLASH_MIME_TYPE = "application/x-shockwave-flash",
    EXPRESS_INSTALL_ID = "SWFObjectExprInst",
    ON_READY_STATE_CHANGE = "onreadystatechange",
    
    win = window,
    doc = document,
    nav = navigator,
    
    plugin = false,
    domLoadFnArr = [main],
    regObjArr = [],
    objIdArr = [],
    listenersArr = [],
    storedAltContent,
    storedAltContentId,
    storedCallbackFn,
    storedCallbackObj,
    isDomLoaded = false,
    isExpressInstallActive = false,
    dynamicStylesheet,
    dynamicStylesheetMedia,
    autoHideShow = true,
  
  /* Centralized function for browser feature detection
    - User agent string detection is only used when no good alternative is possible
    - Is executed directly for optimal performance
  */  
  ua = function() {
    var w3cdom = typeof doc.getElementById != UNDEF && typeof doc.getElementsByTagName != UNDEF && typeof doc.createElement != UNDEF,
      u = nav.userAgent.toLowerCase(),
      p = nav.platform.toLowerCase(),
      windows = p ? /win/.test(p) : /win/.test(u),
      mac = p ? /mac/.test(p) : /mac/.test(u),
      webkit = /webkit/.test(u) ? parseFloat(u.replace(/^.*webkit\/(\d+(\.\d+)?).*$/, "$1")) : false, // returns either the webkit version or false if not webkit
      ie = !+"\v1", // feature detection based on Andrea Giammarchi's solution: http://webreflection.blogspot.com/2009/01/32-bytes-to-know-if-your-browser-is-ie.html
      playerVersion = [0,0,0],
      d = null;
    if (typeof nav.plugins != UNDEF && typeof nav.plugins[SHOCKWAVE_FLASH] == OBJECT) {
      d = nav.plugins[SHOCKWAVE_FLASH].description;
      if (d && !(typeof nav.mimeTypes != UNDEF && nav.mimeTypes[FLASH_MIME_TYPE] && !nav.mimeTypes[FLASH_MIME_TYPE].enabledPlugin)) { // navigator.mimeTypes["application/x-shockwave-flash"].enabledPlugin indicates whether plug-ins are enabled or disabled in Safari 3+
        plugin = true;
        ie = false; // cascaded feature detection for Internet Explorer
        d = d.replace(/^.*\s+(\S+\s+\S+$)/, "$1");
        playerVersion[0] = parseInt(d.replace(/^(.*)\..*$/, "$1"), 10);
        playerVersion[1] = parseInt(d.replace(/^.*\.(.*)\s.*$/, "$1"), 10);
        playerVersion[2] = /[a-zA-Z]/.test(d) ? parseInt(d.replace(/^.*[a-zA-Z]+(.*)$/, "$1"), 10) : 0;
      }
    }
    else if (typeof win.ActiveXObject != UNDEF) {
      try {
        var a = new ActiveXObject(SHOCKWAVE_FLASH_AX);
        if (a) { // a will return null when ActiveX is disabled
          d = a.GetVariable("$version");
          if (d) {
            ie = true; // cascaded feature detection for Internet Explorer
            d = d.split(" ")[1].split(",");
            playerVersion = [parseInt(d[0], 10), parseInt(d[1], 10), parseInt(d[2], 10)];
          }
        }
      }
      catch(e) {}
    }
    return { w3:w3cdom, pv:playerVersion, wk:webkit, ie:ie, win:windows, mac:mac };
  }(),
  
  /* Cross-browser onDomLoad
    - Will fire an event as soon as the DOM of a web page is loaded
    - Internet Explorer workaround based on Diego Perini's solution: http://javascript.nwbox.com/IEContentLoaded/
    - Regular onload serves as fallback
  */ 
  onDomLoad = function() {
    if (!ua.w3) { return; }
    if ((typeof doc.readyState != UNDEF && doc.readyState == "complete") || (typeof doc.readyState == UNDEF && (doc.getElementsByTagName("body")[0] || doc.body))) { // function is fired after onload, e.g. when script is inserted dynamically 
      callDomLoadFunctions();
    }
    if (!isDomLoaded) {
      if (typeof doc.addEventListener != UNDEF) {
        doc.addEventListener("DOMContentLoaded", callDomLoadFunctions, false);
      }   
      if (ua.ie && ua.win) {
        doc.attachEvent(ON_READY_STATE_CHANGE, function() {
          if (doc.readyState == "complete") {
            doc.detachEvent(ON_READY_STATE_CHANGE, arguments.callee);
            callDomLoadFunctions();
          }
        });
        if (win == top) { // if not inside an iframe
          (function(){
            if (isDomLoaded) { return; }
            try {
              doc.documentElement.doScroll("left");
            }
            catch(e) {
              setTimeout(arguments.callee, 0);
              return;
            }
            callDomLoadFunctions();
          })();
        }
      }
      if (ua.wk) {
        (function(){
          if (isDomLoaded) { return; }
          if (!/loaded|complete/.test(doc.readyState)) {
            setTimeout(arguments.callee, 0);
            return;
          }
          callDomLoadFunctions();
        })();
      }
      addLoadEvent(callDomLoadFunctions);
    }
  }();
  
  function callDomLoadFunctions() {
    if (isDomLoaded) { return; }
    try { // test if we can really add/remove elements to/from the DOM; we don't want to fire it too early
      var t = doc.getElementsByTagName("body")[0].appendChild(createElement("span"));
      t.parentNode.removeChild(t);
    }
    catch (e) { return; }
    isDomLoaded = true;
    var dl = domLoadFnArr.length;
    for (var i = 0; i < dl; i++) {
      domLoadFnArr[i]();
    }
  }
  
  function addDomLoadEvent(fn) {
    if (isDomLoaded) {
      fn();
    }
    else { 
      domLoadFnArr[domLoadFnArr.length] = fn; // Array.push() is only available in IE5.5+
    }
  }
  
  /* Cross-browser onload
    - Based on James Edwards' solution: http://brothercake.com/site/resources/scripts/onload/
    - Will fire an event as soon as a web page including all of its assets are loaded 
   */
  function addLoadEvent(fn) {
    if (typeof win.addEventListener != UNDEF) {
      win.addEventListener("load", fn, false);
    }
    else if (typeof doc.addEventListener != UNDEF) {
      doc.addEventListener("load", fn, false);
    }
    else if (typeof win.attachEvent != UNDEF) {
      addListener(win, "onload", fn);
    }
    else if (typeof win.onload == "function") {
      var fnOld = win.onload;
      win.onload = function() {
        fnOld();
        fn();
      };
    }
    else {
      win.onload = fn;
    }
  }
  
  /* Main function
    - Will preferably execute onDomLoad, otherwise onload (as a fallback)
  */
  function main() { 
    if (plugin) {
      testPlayerVersion();
    }
    else {
      matchVersions();
    }
  }
  
  /* Detect the Flash Player version for non-Internet Explorer browsers
    - Detecting the plug-in version via the object element is more precise than using the plugins collection item's description:
      a. Both release and build numbers can be detected
      b. Avoid wrong descriptions by corrupt installers provided by Adobe
      c. Avoid wrong descriptions by multiple Flash Player entries in the plugin Array, caused by incorrect browser imports
    - Disadvantage of this method is that it depends on the availability of the DOM, while the plugins collection is immediately available
  */
  function testPlayerVersion() {
    var b = doc.getElementsByTagName("body")[0];
    var o = createElement(OBJECT);
    o.setAttribute("type", FLASH_MIME_TYPE);
    var t = b.appendChild(o);
    if (t) {
      var counter = 0;
      (function(){
        if (typeof t.GetVariable != UNDEF) {
          var d = t.GetVariable("$version");
          if (d) {
            d = d.split(" ")[1].split(",");
            ua.pv = [parseInt(d[0], 10), parseInt(d[1], 10), parseInt(d[2], 10)];
          }
        }
        else if (counter < 10) {
          counter++;
          setTimeout(arguments.callee, 10);
          return;
        }
        b.removeChild(o);
        t = null;
        matchVersions();
      })();
    }
    else {
      matchVersions();
    }
  }
  
  /* Perform Flash Player and SWF version matching; static publishing only
  */
  function matchVersions() {
    var rl = regObjArr.length;
    if (rl > 0) {
      for (var i = 0; i < rl; i++) { // for each registered object element
        var id = regObjArr[i].id;
        var cb = regObjArr[i].callbackFn;
        var cbObj = {success:false, id:id};
        if (ua.pv[0] > 0) {
          var obj = getElementById(id);
          if (obj) {
            if (hasPlayerVersion(regObjArr[i].swfVersion) && !(ua.wk && ua.wk < 312)) { // Flash Player version >= published SWF version: Houston, we have a match!
              setVisibility(id, true);
              if (cb) {
                cbObj.success = true;
                cbObj.ref = getObjectById(id);
                cb(cbObj);
              }
            }
            else if (regObjArr[i].expressInstall && canExpressInstall()) { // show the Adobe Express Install dialog if set by the web page author and if supported
              var att = {};
              att.data = regObjArr[i].expressInstall;
              att.width = obj.getAttribute("width") || "0";
              att.height = obj.getAttribute("height") || "0";
              if (obj.getAttribute("class")) { att.styleclass = obj.getAttribute("class"); }
              if (obj.getAttribute("align")) { att.align = obj.getAttribute("align"); }
              // parse HTML object param element's name-value pairs
              var par = {};
              var p = obj.getElementsByTagName("param");
              var pl = p.length;
              for (var j = 0; j < pl; j++) {
                if (p[j].getAttribute("name").toLowerCase() != "movie") {
                  par[p[j].getAttribute("name")] = p[j].getAttribute("value");
                }
              }
              showExpressInstall(att, par, id, cb);
            }
            else { // Flash Player and SWF version mismatch or an older Webkit engine that ignores the HTML object element's nested param elements: display alternative content instead of SWF
              displayAltContent(obj);
              if (cb) { cb(cbObj); }
            }
          }
        }
        else {  // if no Flash Player is installed or the fp version cannot be detected we let the HTML object element do its job (either show a SWF or alternative content)
          setVisibility(id, true);
          if (cb) {
            var o = getObjectById(id); // test whether there is an HTML object element or not
            if (o && typeof o.SetVariable != UNDEF) { 
              cbObj.success = true;
              cbObj.ref = o;
            }
            cb(cbObj);
          }
        }
      }
    }
  }
  
  function getObjectById(objectIdStr) {
    var r = null;
    var o = getElementById(objectIdStr);
    if (o && o.nodeName == "OBJECT") {
      if (typeof o.SetVariable != UNDEF) {
        r = o;
      }
      else {
        var n = o.getElementsByTagName(OBJECT)[0];
        if (n) {
          r = n;
        }
      }
    }
    return r;
  }
  
  /* Requirements for Adobe Express Install
    - only one instance can be active at a time
    - fp 6.0.65 or higher
    - Win/Mac OS only
    - no Webkit engines older than version 312
  */
  function canExpressInstall() {
    return !isExpressInstallActive && hasPlayerVersion("6.0.65") && (ua.win || ua.mac) && !(ua.wk && ua.wk < 312);
  }
  
  /* Show the Adobe Express Install dialog
    - Reference: http://www.adobe.com/cfusion/knowledgebase/index.cfm?id=6a253b75
  */
  function showExpressInstall(att, par, replaceElemIdStr, callbackFn) {
    isExpressInstallActive = true;
    storedCallbackFn = callbackFn || null;
    storedCallbackObj = {success:false, id:replaceElemIdStr};
    var obj = getElementById(replaceElemIdStr);
    if (obj) {
      if (obj.nodeName == "OBJECT") { // static publishing
        storedAltContent = abstractAltContent(obj);
        storedAltContentId = null;
      }
      else { // dynamic publishing
        storedAltContent = obj;
        storedAltContentId = replaceElemIdStr;
      }
      att.id = EXPRESS_INSTALL_ID;
      if (typeof att.width == UNDEF || (!/%$/.test(att.width) && parseInt(att.width, 10) < 310)) { att.width = "310"; }
      if (typeof att.height == UNDEF || (!/%$/.test(att.height) && parseInt(att.height, 10) < 137)) { att.height = "137"; }
      doc.title = doc.title.slice(0, 47) + " - Flash Player Installation";
      var pt = ua.ie && ua.win ? "ActiveX" : "PlugIn",
        fv = "MMredirectURL=" + win.location.toString().replace(/&/g,"%26") + "&MMplayerType=" + pt + "&MMdoctitle=" + doc.title;
      if (typeof par.flashvars != UNDEF) {
        par.flashvars += "&" + fv;
      }
      else {
        par.flashvars = fv;
      }
      // IE only: when a SWF is loading (AND: not available in cache) wait for the readyState of the object element to become 4 before removing it,
      // because you cannot properly cancel a loading SWF file without breaking browser load references, also obj.onreadystatechange doesn't work
      if (ua.ie && ua.win && obj.readyState != 4) {
        var newObj = createElement("div");
        replaceElemIdStr += "SWFObjectNew";
        newObj.setAttribute("id", replaceElemIdStr);
        obj.parentNode.insertBefore(newObj, obj); // insert placeholder div that will be replaced by the object element that loads expressinstall.swf
        obj.style.display = "none";
        (function(){
          if (obj.readyState == 4) {
            obj.parentNode.removeChild(obj);
          }
          else {
            setTimeout(arguments.callee, 10);
          }
        })();
      }
      createSWF(att, par, replaceElemIdStr);
    }
  }
  
  /* Functions to abstract and display alternative content
  */
  function displayAltContent(obj) {
    if (ua.ie && ua.win && obj.readyState != 4) {
      // IE only: when a SWF is loading (AND: not available in cache) wait for the readyState of the object element to become 4 before removing it,
      // because you cannot properly cancel a loading SWF file without breaking browser load references, also obj.onreadystatechange doesn't work
      var el = createElement("div");
      obj.parentNode.insertBefore(el, obj); // insert placeholder div that will be replaced by the alternative content
      el.parentNode.replaceChild(abstractAltContent(obj), el);
      obj.style.display = "none";
      (function(){
        if (obj.readyState == 4) {
          obj.parentNode.removeChild(obj);
        }
        else {
          setTimeout(arguments.callee, 10);
        }
      })();
    }
    else {
      obj.parentNode.replaceChild(abstractAltContent(obj), obj);
    }
  } 

  function abstractAltContent(obj) {
    var ac = createElement("div");
    if (ua.win && ua.ie) {
      ac.innerHTML = obj.innerHTML;
    }
    else {
      var nestedObj = obj.getElementsByTagName(OBJECT)[0];
      if (nestedObj) {
        var c = nestedObj.childNodes;
        if (c) {
          var cl = c.length;
          for (var i = 0; i < cl; i++) {
            if (!(c[i].nodeType == 1 && c[i].nodeName == "PARAM") && !(c[i].nodeType == 8)) {
              ac.appendChild(c[i].cloneNode(true));
            }
          }
        }
      }
    }
    return ac;
  }
  
  /* Cross-browser dynamic SWF creation
  */
  function createSWF(attObj, parObj, id) {
    var r, el = getElementById(id);
    if (ua.wk && ua.wk < 312) { return r; }
    if (el) {
      if (typeof attObj.id == UNDEF) { // if no 'id' is defined for the object element, it will inherit the 'id' from the alternative content
        attObj.id = id;
      }
      if (ua.ie && ua.win) { // Internet Explorer + the HTML object element + W3C DOM methods do not combine: fall back to outerHTML
        var att = "";
        for (var i in attObj) {
          if (attObj[i] != Object.prototype[i]) { // filter out prototype additions from other potential libraries
            if (i.toLowerCase() == "data") {
              parObj.movie = attObj[i];
            }
            else if (i.toLowerCase() == "styleclass") { // 'class' is an ECMA4 reserved keyword
              att += ' class="' + attObj[i] + '"';
            }
            else if (i.toLowerCase() != "classid") {
              att += ' ' + i + '="' + attObj[i] + '"';
            }
          }
        }
        var par = "";
        for (var j in parObj) {
          if (parObj[j] != Object.prototype[j]) { // filter out prototype additions from other potential libraries
            par += '<param name="' + j + '" value="' + parObj[j] + '" />';
          }
        }
        el.outerHTML = '<object classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"' + att + '>' + par + '</object>';
        objIdArr[objIdArr.length] = attObj.id; // stored to fix object 'leaks' on unload (dynamic publishing only)
        r = getElementById(attObj.id);  
      }
      else { // well-behaving browsers
        var o = createElement(OBJECT);
        o.setAttribute("type", FLASH_MIME_TYPE);
        for (var m in attObj) {
          if (attObj[m] != Object.prototype[m]) { // filter out prototype additions from other potential libraries
            if (m.toLowerCase() == "styleclass") { // 'class' is an ECMA4 reserved keyword
              o.setAttribute("class", attObj[m]);
            }
            else if (m.toLowerCase() != "classid") { // filter out IE specific attribute
              o.setAttribute(m, attObj[m]);
            }
          }
        }
        for (var n in parObj) {
          if (parObj[n] != Object.prototype[n] && n.toLowerCase() != "movie") { // filter out prototype additions from other potential libraries and IE specific param element
            createObjParam(o, n, parObj[n]);
          }
        }
        el.parentNode.replaceChild(o, el);
        r = o;
      }
    }
    return r;
  }
  
  function createObjParam(el, pName, pValue) {
    var p = createElement("param");
    p.setAttribute("name", pName);  
    p.setAttribute("value", pValue);
    el.appendChild(p);
  }
  
  /* Cross-browser SWF removal
    - Especially needed to safely and completely remove a SWF in Internet Explorer
  */
  function removeSWF(id) {
    var obj = getElementById(id);
    if (obj && obj.nodeName == "OBJECT") {
      if (ua.ie && ua.win) {
        obj.style.display = "none";
        (function(){
          if (obj.readyState == 4) {
            removeObjectInIE(id);
          }
          else {
            setTimeout(arguments.callee, 10);
          }
        })();
      }
      else {
        obj.parentNode.removeChild(obj);
      }
    }
  }
  
  function removeObjectInIE(id) {
    var obj = getElementById(id);
    if (obj) {
      for (var i in obj) {
        if (typeof obj[i] == "function") {
          obj[i] = null;
        }
      }
      obj.parentNode.removeChild(obj);
    }
  }
  
  /* Functions to optimize JavaScript compression
  */
  function getElementById(id) {
    var el = null;
    try {
      el = doc.getElementById(id);
    }
    catch (e) {}
    return el;
  }
  
  function createElement(el) {
    return doc.createElement(el);
  }
  
  /* Updated attachEvent function for Internet Explorer
    - Stores attachEvent information in an Array, so on unload the detachEvent functions can be called to avoid memory leaks
  */  
  function addListener(target, eventType, fn) {
    target.attachEvent(eventType, fn);
    listenersArr[listenersArr.length] = [target, eventType, fn];
  }
  
  /* Flash Player and SWF content version matching
  */
  function hasPlayerVersion(rv) {
    var pv = ua.pv, v = rv.split(".");
    v[0] = parseInt(v[0], 10);
    v[1] = parseInt(v[1], 10) || 0; // supports short notation, e.g. "9" instead of "9.0.0"
    v[2] = parseInt(v[2], 10) || 0;
    return (pv[0] > v[0] || (pv[0] == v[0] && pv[1] > v[1]) || (pv[0] == v[0] && pv[1] == v[1] && pv[2] >= v[2])) ? true : false;
  }
  
  /* Cross-browser dynamic CSS creation
    - Based on Bobby van der Sluis' solution: http://www.bobbyvandersluis.com/articles/dynamicCSS.php
  */  
  function createCSS(sel, decl, media, newStyle) {
    if (ua.ie && ua.mac) { return; }
    var h = doc.getElementsByTagName("head")[0];
    if (!h) { return; } // to also support badly authored HTML pages that lack a head element
    var m = (media && typeof media == "string") ? media : "screen";
    if (newStyle) {
      dynamicStylesheet = null;
      dynamicStylesheetMedia = null;
    }
    if (!dynamicStylesheet || dynamicStylesheetMedia != m) { 
      // create dynamic stylesheet + get a global reference to it
      var s = createElement("style");
      s.setAttribute("type", "text/css");
      s.setAttribute("media", m);
      dynamicStylesheet = h.appendChild(s);
      if (ua.ie && ua.win && typeof doc.styleSheets != UNDEF && doc.styleSheets.length > 0) {
        dynamicStylesheet = doc.styleSheets[doc.styleSheets.length - 1];
      }
      dynamicStylesheetMedia = m;
    }
    // add style rule
    if (ua.ie && ua.win) {
      if (dynamicStylesheet && typeof dynamicStylesheet.addRule == OBJECT) {
        dynamicStylesheet.addRule(sel, decl);
      }
    }
    else {
      if (dynamicStylesheet && typeof doc.createTextNode != UNDEF) {
        dynamicStylesheet.appendChild(doc.createTextNode(sel + " {" + decl + "}"));
      }
    }
  }
  
  function setVisibility(id, isVisible) {
    if (!autoHideShow) { return; }
    var v = isVisible ? "visible" : "hidden";
    if (isDomLoaded && getElementById(id)) {
      getElementById(id).style.visibility = v;
    }
    else {
      createCSS("#" + id, "visibility:" + v);
    }
  }

  /* Filter to avoid XSS attacks
  */
  function urlEncodeIfNecessary(s) {
    var regex = /[\\\"<>\.;]/;
    var hasBadChars = regex.exec(s) != null;
    return hasBadChars && typeof encodeURIComponent != UNDEF ? encodeURIComponent(s) : s;
  }
  
  /* Release memory to avoid memory leaks caused by closures, fix hanging audio/video threads and force open sockets/NetConnections to disconnect (Internet Explorer only)
  */
  var cleanup = function() {
    if (ua.ie && ua.win) {
      window.attachEvent("onunload", function() {
        // remove listeners to avoid memory leaks
        var ll = listenersArr.length;
        for (var i = 0; i < ll; i++) {
          listenersArr[i][0].detachEvent(listenersArr[i][1], listenersArr[i][2]);
        }
        // cleanup dynamically embedded objects to fix audio/video threads and force open sockets and NetConnections to disconnect
        var il = objIdArr.length;
        for (var j = 0; j < il; j++) {
          removeSWF(objIdArr[j]);
        }
        // cleanup library's main closures to avoid memory leaks
        for (var k in ua) {
          ua[k] = null;
        }
        ua = null;
        for (var l in swfobject) {
          swfobject[l] = null;
        }
        swfobject = null;
      });
    }
  }();
  
  return {
    /* Public API
      - Reference: http://code.google.com/p/swfobject/wiki/documentation
    */ 
    registerObject: function(objectIdStr, swfVersionStr, xiSwfUrlStr, callbackFn) {
      if (ua.w3 && objectIdStr && swfVersionStr) {
        var regObj = {};
        regObj.id = objectIdStr;
        regObj.swfVersion = swfVersionStr;
        regObj.expressInstall = xiSwfUrlStr;
        regObj.callbackFn = callbackFn;
        regObjArr[regObjArr.length] = regObj;
        setVisibility(objectIdStr, false);
      }
      else if (callbackFn) {
        callbackFn({success:false, id:objectIdStr});
      }
    },
    
    getObjectById: function(objectIdStr) {
      if (ua.w3) {
        return getObjectById(objectIdStr);
      }
    },
    
    embedSWF: function(swfUrlStr, replaceElemIdStr, widthStr, heightStr, swfVersionStr, xiSwfUrlStr, flashvarsObj, parObj, attObj, callbackFn) {
      var callbackObj = {success:false, id:replaceElemIdStr};
      if (ua.w3 && !(ua.wk && ua.wk < 312) && swfUrlStr && replaceElemIdStr && widthStr && heightStr && swfVersionStr) {
        setVisibility(replaceElemIdStr, false);
        addDomLoadEvent(function() {
          widthStr += ""; // auto-convert to string
          heightStr += "";
          var att = {};
          if (attObj && typeof attObj === OBJECT) {
            for (var i in attObj) { // copy object to avoid the use of references, because web authors often reuse attObj for multiple SWFs
              att[i] = attObj[i];
            }
          }
          att.data = swfUrlStr;
          att.width = widthStr;
          att.height = heightStr;
          var par = {}; 
          if (parObj && typeof parObj === OBJECT) {
            for (var j in parObj) { // copy object to avoid the use of references, because web authors often reuse parObj for multiple SWFs
              par[j] = parObj[j];
            }
          }
          if (flashvarsObj && typeof flashvarsObj === OBJECT) {
            for (var k in flashvarsObj) { // copy object to avoid the use of references, because web authors often reuse flashvarsObj for multiple SWFs
              if (typeof par.flashvars != UNDEF) {
                par.flashvars += "&" + k + "=" + flashvarsObj[k];
              }
              else {
                par.flashvars = k + "=" + flashvarsObj[k];
              }
            }
          }
          if (hasPlayerVersion(swfVersionStr)) { // create SWF
            var obj = createSWF(att, par, replaceElemIdStr);
            if (att.id == replaceElemIdStr) {
              setVisibility(replaceElemIdStr, true);
            }
            callbackObj.success = true;
            callbackObj.ref = obj;
          }
          else if (xiSwfUrlStr && canExpressInstall()) { // show Adobe Express Install
            att.data = xiSwfUrlStr;
            showExpressInstall(att, par, replaceElemIdStr, callbackFn);
            return;
          }
          else { // show alternative content
            setVisibility(replaceElemIdStr, true);
          }
          if (callbackFn) { callbackFn(callbackObj); }
        });
      }
      else if (callbackFn) { callbackFn(callbackObj); }
    },
    
    switchOffAutoHideShow: function() {
      autoHideShow = false;
    },
    
    ua: ua,
    
    getFlashPlayerVersion: function() {
      return { major:ua.pv[0], minor:ua.pv[1], release:ua.pv[2] };
    },
    
    hasFlashPlayerVersion: hasPlayerVersion,
    
    createSWF: function(attObj, parObj, replaceElemIdStr) {
      if (ua.w3) {
        return createSWF(attObj, parObj, replaceElemIdStr);
      }
      else {
        return undefined;
      }
    },
    
    showExpressInstall: function(att, par, replaceElemIdStr, callbackFn) {
      if (ua.w3 && canExpressInstall()) {
        showExpressInstall(att, par, replaceElemIdStr, callbackFn);
      }
    },
    
    removeSWF: function(objElemIdStr) {
      if (ua.w3) {
        removeSWF(objElemIdStr);
      }
    },
    
    createCSS: function(selStr, declStr, mediaStr, newStyleBoolean) {
      if (ua.w3) {
        createCSS(selStr, declStr, mediaStr, newStyleBoolean);
      }
    },
    
    addDomLoadEvent: addDomLoadEvent,
    
    addLoadEvent: addLoadEvent,
    
    getQueryParamValue: function(param) {
      var q = doc.location.search || doc.location.hash;
      if (q) {
        if (/\?/.test(q)) { q = q.split("?")[1]; } // strip question mark
        if (param == null) {
          return urlEncodeIfNecessary(q);
        }
        var pairs = q.split("&");
        for (var i = 0; i < pairs.length; i++) {
          if (pairs[i].substring(0, pairs[i].indexOf("=")) == param) {
            return urlEncodeIfNecessary(pairs[i].substring((pairs[i].indexOf("=") + 1)));
          }
        }
      }
      return "";
    },
    
    // For internal usage only
    expressInstallCallback: function() {
      if (isExpressInstallActive) {
        var obj = getElementById(EXPRESS_INSTALL_ID);
        if (obj && storedAltContent) {
          obj.parentNode.replaceChild(storedAltContent, obj);
          if (storedAltContentId) {
            setVisibility(storedAltContentId, true);
            if (ua.ie && ua.win) { storedAltContent.style.display = "block"; }
          }
          if (storedCallbackFn) { storedCallbackFn(storedCallbackObj); }
        }
        isExpressInstallActive = false;
      } 
    }
  };
}();
;
    (function(exports) {
    exports.BloomFilter = BloomFilter;
    exports.fnv_1a = fnv_1a;
    exports.fnv_1a_b = fnv_1a_b;

    var typedArrays = typeof ArrayBuffer !== "undefined";

    // Creates a new bloom filter.  If *m* is an array-like object, with a length
    // property, then the bloom filter is loaded with data from the array, where
    // each element is a 32-bit integer.  Otherwise, *m* should specify the
    // number of bits.  *k* specifies the number of hashing functions.
    function BloomFilter(m, k) {
      var a;
      if (typeof m !== "number") a = m, m = a.length * 32;

      this.m = m;
      this.k = k;
      var n = Math.ceil(m / 32),
          i = -1;

      if (typedArrays) {
        var kbytes = 1 << Math.ceil(Math.log(Math.ceil(Math.log(m) / Math.LN2 / 8)) / Math.LN2),
            array = kbytes === 1 ? Uint8Array : kbytes === 2 ? Uint16Array : Uint32Array,
            kbuffer = new ArrayBuffer(kbytes * k),
            buckets = this.buckets = new Int32Array(n);
        if (a) while (++i < n) buckets[i] = a[i];
        this._locations = new array(kbuffer);
      } else {
        var buckets = this.buckets = [];
        if (a) while (++i < n) buckets[i] = a[i];
        else while (++i < n) buckets[i] = 0;
        this._locations = [];
      }
    }

    // See http://willwhim.wordpress.com/2011/09/03/producing-n-hash-functions-by-hashing-only-once/
    BloomFilter.prototype.locations = function(v) {
      var k = this.k,
          m = this.m,
          r = this._locations,
          a = fnv_1a(v),
          b = fnv_1a_b(a),
          i = -1,
          x = a % m;
      while (++i < k) {
        r[i] = x < 0 ? (x + m) : x;
        x = (x + b) % m;
      }
      return r;
    };

    BloomFilter.prototype.add = function(v) {
      var l = this.locations(v + ""),
          i = -1,
          k = this.k,
          buckets = this.buckets;
      while (++i < k) buckets[Math.floor(l[i] / 32)] |= 1 << (l[i] % 32);
    };

    BloomFilter.prototype.test = function(v) {
      var l = this.locations(v + ""),
          i = -1,
          k = this.k,
          b,
          buckets = this.buckets;
      while (++i < k) {
        b = l[i];
        if ((buckets[Math.floor(b / 32)] & (1 << (b % 32))) === 0) {
          return false;
        }
      }
      return true;
    };

    // Fowler/Noll/Vo hashing.
    function fnv_1a(v) {
      var n = v.length,
          a = 2166136261,
          c,
          d,
          i = -1;
      while (++i < n) {
        c = v.charCodeAt(i);
        if (d = c & 0xff000000) {
          a ^= d >> 24;
          a += (a << 1) + (a << 4) + (a << 7) + (a << 8) + (a << 24);
        }
        if (d = c & 0xff0000) {
          a ^= d >> 16;
          a += (a << 1) + (a << 4) + (a << 7) + (a << 8) + (a << 24);
        }
        if (d = c & 0xff00) {
          a ^= d >> 8;
          a += (a << 1) + (a << 4) + (a << 7) + (a << 8) + (a << 24);
        }
        a ^= c & 0xff;
        a += (a << 1) + (a << 4) + (a << 7) + (a << 8) + (a << 24);
      }
      // From http://home.comcast.net/~bretm/hash/6.html
      a += a << 13;
      a ^= a >> 7;
      a += a << 3;
      a ^= a >> 17;
      a += a << 5;
      return a & 0xffffffff;
    }

    // One additional iteration of FNV, given a hash.
    function fnv_1a_b(a) {
      a += (a << 1) + (a << 4) + (a << 7) + (a << 8) + (a << 24);
      a += a << 13;
      a ^= a >> 7;
      a += a << 3;
      a ^= a >> 17;
      a += a << 5;
      return a & 0xffffffff;
    }
  })(typeof exports !== "undefined" ? exports : this);;
    /*! JSON v3.2.4 | http://bestiejs.github.com/json3 | Copyright 2012, Kit Cambridge | http://kit.mit-license.org */
  ;(function(){var e=void 0,i=!0,k=null,l={}.toString,m,n,p="function"===typeof define&&define.c,q=!p&&"object"==typeof exports&&exports;q||p?"object"==typeof JSON&&JSON?p?q=JSON:(q.stringify=JSON.stringify,q.parse=JSON.parse):p&&(q=this.JSON={}):q=this.JSON||(this.JSON={});var r,t,u,x,z,B,C,D,E,F,G,H,I,J=new Date(-3509827334573292),K,O,P;try{J=-109252==J.getUTCFullYear()&&0===J.getUTCMonth()&&1==J.getUTCDate()&&10==J.getUTCHours()&&37==J.getUTCMinutes()&&6==J.getUTCSeconds()&&708==J.getUTCMilliseconds()}catch(Q){}
  function R(b){var c,a,d,j=b=="json";if(j||b=="json-stringify"||b=="json-parse"){if(b=="json-stringify"||j){if(c=typeof q.stringify=="function"&&J){(d=function(){return 1}).toJSON=d;try{c=q.stringify(0)==="0"&&q.stringify(new Number)==="0"&&q.stringify(new String)=='""'&&q.stringify(l)===e&&q.stringify(e)===e&&q.stringify()===e&&q.stringify(d)==="1"&&q.stringify([d])=="[1]"&&q.stringify([e])=="[null]"&&q.stringify(k)=="null"&&q.stringify([e,l,k])=="[null,null,null]"&&q.stringify({A:[d,i,false,k,"\x00\u0008\n\u000c\r\t"]})==
  '{"A":[1,true,false,null,"\\u0000\\b\\n\\f\\r\\t"]}'&&q.stringify(k,d)==="1"&&q.stringify([1,2],k,1)=="[\n 1,\n 2\n]"&&q.stringify(new Date(-864E13))=='"-271821-04-20T00:00:00.000Z"'&&q.stringify(new Date(864E13))=='"+275760-09-13T00:00:00.000Z"'&&q.stringify(new Date(-621987552E5))=='"-000001-01-01T00:00:00.000Z"'&&q.stringify(new Date(-1))=='"1969-12-31T23:59:59.999Z"'}catch(f){c=false}}if(!j)return c}if(b=="json-parse"||j){if(typeof q.parse=="function")try{if(q.parse("0")===0&&!q.parse(false)){d=
  q.parse('{"A":[1,true,false,null,"\\u0000\\b\\n\\f\\r\\t"]}');if(a=d.a.length==5&&d.a[0]==1){try{a=!q.parse('"\t"')}catch(o){}if(a)try{a=q.parse("01")!=1}catch(g){}}}}catch(h){a=false}if(!j)return a}return c&&a}}
  if(!R("json")){J||(K=Math.floor,O=[0,31,59,90,120,151,181,212,243,273,304,334],P=function(b,c){return O[c]+365*(b-1970)+K((b-1969+(c=+(c>1)))/4)-K((b-1901+c)/100)+K((b-1601+c)/400)});if(!(m={}.hasOwnProperty))m=function(b){var c={},a;if((c.__proto__=k,c.__proto__={toString:1},c).toString!=l)m=function(a){var b=this.__proto__,a=a in(this.__proto__=k,this);this.__proto__=b;return a};else{a=c.constructor;m=function(b){var c=(this.constructor||a).prototype;return b in this&&!(b in c&&this[b]===c[b])}}c=
  k;return m.call(this,b)};n=function(b,c){var a=0,d,j,f;(d=function(){this.valueOf=0}).prototype.valueOf=0;j=new d;for(f in j)m.call(j,f)&&a++;d=j=k;if(a)a=a==2?function(a,b){var c={},d=l.call(a)=="[object Function]",f;for(f in a)!(d&&f=="prototype")&&!m.call(c,f)&&(c[f]=1)&&m.call(a,f)&&b(f)}:function(a,b){var c=l.call(a)=="[object Function]",d,f;for(d in a)!(c&&d=="prototype")&&m.call(a,d)&&!(f=d==="constructor")&&b(d);(f||m.call(a,d="constructor"))&&b(d)};else{j=["valueOf","toString","toLocaleString",
  "propertyIsEnumerable","isPrototypeOf","hasOwnProperty","constructor"];a=function(a,b){var c=l.call(a)=="[object Function]",d;for(d in a)!(c&&d=="prototype")&&m.call(a,d)&&b(d);for(c=j.length;d=j[--c];m.call(a,d)&&b(d));}}a(b,c)};R("json-stringify")||(r={"\\":"\\\\",'"':'\\"',"\u0008":"\\b","\u000c":"\\f","\n":"\\n","\r":"\\r","\t":"\\t"},t=function(b,c){return("000000"+(c||0)).slice(-b)},u=function(b){for(var c='"',a=0,d;d=b.charAt(a);a++)c=c+('\\"\u0008\u000c\n\r\t'.indexOf(d)>-1?r[d]:r[d]=d<" "?
  "\\u00"+t(2,d.charCodeAt(0).toString(16)):d);return c+'"'},x=function(b,c,a,d,j,f,o){var g=c[b],h,s,v,w,L,M,N,y,A;if(typeof g=="object"&&g){h=l.call(g);if(h=="[object Date]"&&!m.call(g,"toJSON"))if(g>-1/0&&g<1/0){if(P){v=K(g/864E5);for(h=K(v/365.2425)+1970-1;P(h+1,0)<=v;h++);for(s=K((v-P(h,0))/30.42);P(h,s+1)<=v;s++);v=1+v-P(h,s);w=(g%864E5+864E5)%864E5;L=K(w/36E5)%24;M=K(w/6E4)%60;N=K(w/1E3)%60;w=w%1E3}else{h=g.getUTCFullYear();s=g.getUTCMonth();v=g.getUTCDate();L=g.getUTCHours();M=g.getUTCMinutes();
  N=g.getUTCSeconds();w=g.getUTCMilliseconds()}g=(h<=0||h>=1E4?(h<0?"-":"+")+t(6,h<0?-h:h):t(4,h))+"-"+t(2,s+1)+"-"+t(2,v)+"T"+t(2,L)+":"+t(2,M)+":"+t(2,N)+"."+t(3,w)+"Z"}else g=k;else if(typeof g.toJSON=="function"&&(h!="[object Number]"&&h!="[object String]"&&h!="[object Array]"||m.call(g,"toJSON")))g=g.toJSON(b)}a&&(g=a.call(c,b,g));if(g===k)return"null";h=l.call(g);if(h=="[object Boolean]")return""+g;if(h=="[object Number]")return g>-1/0&&g<1/0?""+g:"null";if(h=="[object String]")return u(g);if(typeof g==
  "object"){for(b=o.length;b--;)if(o[b]===g)throw TypeError();o.push(g);y=[];c=f;f=f+j;if(h=="[object Array]"){s=0;for(b=g.length;s<b;A||(A=i),s++){h=x(s,g,a,d,j,f,o);y.push(h===e?"null":h)}b=A?j?"[\n"+f+y.join(",\n"+f)+"\n"+c+"]":"["+y.join(",")+"]":"[]"}else{n(d||g,function(b){var c=x(b,g,a,d,j,f,o);c!==e&&y.push(u(b)+":"+(j?" ":"")+c);A||(A=i)});b=A?j?"{\n"+f+y.join(",\n"+f)+"\n"+c+"}":"{"+y.join(",")+"}":"{}"}o.pop();return b}},q.stringify=function(b,c,a){var d,j,f,o,g,h;if(typeof c=="function"||
  typeof c=="object"&&c)if(l.call(c)=="[object Function]")j=c;else if(l.call(c)=="[object Array]"){f={};o=0;for(g=c.length;o<g;h=c[o++],(l.call(h)=="[object String]"||l.call(h)=="[object Number]")&&(f[h]=1));}if(a)if(l.call(a)=="[object Number]"){if((a=a-a%1)>0){d="";for(a>10&&(a=10);d.length<a;d=d+" ");}}else l.call(a)=="[object String]"&&(d=a.length<=10?a:a.slice(0,10));return x("",(h={},h[""]=b,h),j,f,d,"",[])});R("json-parse")||(z=String.fromCharCode,B={"\\":"\\",'"':'"',"/":"/",b:"\u0008",t:"\t",
  n:"\n",f:"\u000c",r:"\r"},C=function(){H=I=k;throw SyntaxError();},D=function(){for(var b=I,c=b.length,a,d,j,f,o;H<c;){a=b.charAt(H);if("\t\r\n ".indexOf(a)>-1)H++;else{if("{}[]:,".indexOf(a)>-1){H++;return a}if(a=='"'){d="@";for(H++;H<c;){a=b.charAt(H);if(a<" ")C();else if(a=="\\"){a=b.charAt(++H);if('\\"/btnfr'.indexOf(a)>-1){d=d+B[a];H++}else if(a=="u"){j=++H;for(f=H+4;H<f;H++){a=b.charAt(H);a>="0"&&a<="9"||a>="a"&&a<="f"||a>="A"&&a<="F"||C()}d=d+z("0x"+b.slice(j,H))}else C()}else{if(a=='"')break;
  d=d+a;H++}}if(b.charAt(H)=='"'){H++;return d}}else{j=H;if(a=="-"){o=i;a=b.charAt(++H)}if(a>="0"&&a<="9"){for(a=="0"&&(a=b.charAt(H+1),a>="0"&&a<="9")&&C();H<c&&(a=b.charAt(H),a>="0"&&a<="9");H++);if(b.charAt(H)=="."){for(f=++H;f<c&&(a=b.charAt(f),a>="0"&&a<="9");f++);f==H&&C();H=f}a=b.charAt(H);if(a=="e"||a=="E"){a=b.charAt(++H);(a=="+"||a=="-")&&H++;for(f=H;f<c&&(a=b.charAt(f),a>="0"&&a<="9");f++);f==H&&C();H=f}return+b.slice(j,H)}o&&C();if(b.slice(H,H+4)=="true"){H=H+4;return i}if(b.slice(H,H+5)==
  "false"){H=H+5;return false}if(b.slice(H,H+4)=="null"){H=H+4;return k}}C()}}return"$"},E=function(b){var c,a;b=="$"&&C();if(typeof b=="string"){if(b.charAt(0)=="@")return b.slice(1);if(b=="["){for(c=[];;a||(a=i)){b=D();if(b=="]")break;if(a)if(b==","){b=D();b=="]"&&C()}else C();b==","&&C();c.push(E(b))}return c}if(b=="{"){for(c={};;a||(a=i)){b=D();if(b=="}")break;if(a)if(b==","){b=D();b=="}"&&C()}else C();(b==","||typeof b!="string"||b.charAt(0)!="@"||D()!=":")&&C();c[b.slice(1)]=E(D())}return c}C()}return b},
  G=function(b,c,a){a=F(b,c,a);a===e?delete b[c]:b[c]=a},F=function(b,c,a){var d=b[c],j;if(typeof d=="object"&&d)if(l.call(d)=="[object Array]")for(j=d.length;j--;)G(d,j,a);else n(d,function(b){G(d,b,a)});return a.call(b,c,d)},q.parse=function(b,c){var a,d;H=0;I=b;a=E(D());D()!="$"&&C();H=I=k;return c&&l.call(c)=="[object Function]"?F((d={},d[""]=a,d),"",c):a})}p&&define(function(){return q});
  }());;
    ;(function () {
    var
      object = typeof window != 'undefined' ? window : exports,
      chars = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/=',
      INVALID_CHARACTER_ERR = (function () {
        // fabricate a suitable error object
        try { document.createElement('$'); }
        catch (error) { return error; }}());

    // encoder
    // [https://gist.github.com/999166] by [https://github.com/nignag]
    object.btoa || (
    object.btoa = function (input) {
      for (
        // initialize result and counter
        var block, charCode, idx = 0, map = chars, output = '';
        // if the next input index does not exist:
        //   change the mapping table to "="
        //   check if d has no fractional digits
        input.charAt(idx | 0) || (map = '=', idx % 1);
        // "8 - idx % 1 * 8" generates the sequence 2, 4, 6, 8
        output += map.charAt(63 & block >> 8 - idx % 1 * 8)
      ) {
        charCode = input.charCodeAt(idx += 3/4);
        if (charCode > 0xFF) throw INVALID_CHARACTER_ERR;
        block = block << 8 | charCode;
      }
      return output;
    });

    // decoder
    // [https://gist.github.com/1020396] by [https://github.com/atk]
    object.atob || (
    object.atob = function (input) {
      input = input.replace(/=+$/, '')
      if (input.length % 4 == 1) throw INVALID_CHARACTER_ERR;
      for (
        // initialize result and counters
        var bc = 0, bs, buffer, idx = 0, output = '';
        // get next character
        buffer = input.charAt(idx++);
        // character found in table? initialize bit storage and add its ascii value;
        ~buffer && (bs = bc % 4 ? bs * 64 + buffer : buffer,
          // and if not first of each 4 characters,
          // convert the first 8 bits to one ascii character
          bc++ % 4) ? output += String.fromCharCode(255 & bs >> (-2 * bc & 6)) : 0
      ) {
        // try to find character in table (0-63, not found => -1)
        buffer = chars.indexOf(buffer);
      }
      return output;
    });

  }());;
    Object.Keys = Object.keys = Object.keys || 
      function ( 
          o, // object
          k, // key
          r  // result array
      ){
          // initialize object and result
          r=[];
          // iterate over object keys
          for (k in o) 
              // fill result array with non-prototypical keys
              r.hasOwnProperty.call(o, k) && r.push(k);
          // return result
          return r
      }
      ;
    now = function() {
      return Number(new Date().getTime());
    };
    start = now();
    nowdf = function() {
      return now() - start;
    };
    ct = window.ozoki_ct;
    if ((ct.ac != null) && ct.pi === "someref.com") {
      ct.qa = 1;
    }
    if (window.ozoki_os == null) {
      os = "ozoki.com";
    } else {
      os = window.ozoki_os;
    }
    sos = os.split(".");
    if (sos[0] === "post" || sos[0] === "get") {
      os = sos.slice(1).join(".");
    }
    ct.oz_st = start;
    if (sos[0] === "s-update") {
      postdest = "//update." + sos.slice(1).join(".");
      getdest = "//s-update." + sos.slice(1).join(".");
    } else if (sos[1] === "cloudfront") {
      postdest = getdest = os;
    } else if (sos[0] === "u" || sos[0] === "p") {
      postdest = "//p." + sos.slice(1).join(".");
      getdest = "//u." + sos.slice(1).join(".");
    } else if (os.indexOf("post.") === -1 && os.indexOf("s.") === -1) {
      postdest = "//post." + os;
      getdest = "//s." + os;
    } else {
      postdest = "//post.ozoki.com";
      getdest = "//s.ozoki.com";
    }
    worked = {};
    proto = window.location.protocol;
    if (proto === "https:") {
      getdest = postdest;
    }
    conservative = false;
    if (ct.ci === "tm01") {
      conservative = true;
    }
    if (ct.qa != null) {
      conservative = false;
    }
    sc = "";
    go_on = function() {
      var RAF_prev_average, attributes, btdata, collectInitdata, collectPlugins, collectWebGL, copy, createDomChecker, createHTML5Checker, createLatencyChecker, createMouseChecker, createRAFChecker, createSimplePingbacks, createStorageChecker, createVisibilityEvent, createVizBase, curiousDump, doHello1, doHello16, doHello2, doHello32, doHello4, doHello8, emit, emitAsCORSXHR, emitAsIframePost, emitAsImage, emit_method, emitcount, flashvars, getCORS, getFrameDepth, getScd, getViewport, get_keys, makeDiv, makePrint, makeUrlString, nocors, params;
      if ((ct.oz_sc == null) || (sc == null) || ct.oz_sc === "") {
        sc = ct.oz_sc = get_sc_last_resort(12);
        ct.oz_xx = 1;
      }
      emitcount = 0;
      nocors = null;
      getCORS = function() {
        var xhr;
        if (nocors === true) {
          return null;
        }
        if (typeof XMLHttpRequest !== "undefined" && XMLHttpRequest !== null) {
          xhr = new XMLHttpRequest();
          if (xhr.withCredentials != null) {
            return xhr;
          } else {
            if (typeof XDomainRequest !== "undefined" && XDomainRequest !== null) {
              return new XDomainRequest();
            }
          }
        }
        nocors = true;
        return null;
      };
      emit = function(submission) {
        var enc;
        if (nowdf() > 120000) {
          return;
        }
        if (emitcount++ > 64) {
          return;
        }
        enc = JSON.stringify(submission);
        if (enc.length === 0) {
          return;
        }
        return emit_method(enc);
      };
      makeUrlString = function(obj) {
        var a, k, pair, _i, _len, _ref;
        a = [];
        _ref = Object.keys(obj);
        for (_i = 0, _len = _ref.length; _i < _len; _i++) {
          k = _ref[_i];
          pair = [k, obj[k]];
          a.push(pair.join("="));
        }
        return a.join("&");
      };
      copy = function(obj) {
        return JSON.parse(JSON.stringify(obj));
      };
      emitAsIframePost = function(enc) {
        var chunk, chunkSize, del, form, i, ifr, input, next_chunk, xct;
        try {
          window.statusbar = false;
        } catch (_error) {}
        ifr = document.createElement("iframe");
        ifr.style.display = "none";
        document.body.appendChild(ifr);
        ifr.contentWindow.name = String(Math.random()) + String(Math.random());
        form = document.createElement("form");
        form.style.display = "none";
        document.body.appendChild(form);
        form.target = ifr.contentWindow.name;
        form.enctype = "multipart/form-data";
        xct = copy(ct);
        xct.oz_df = nowdf();
        form.action = postdest + "/postback_ifr?" + makeUrlString(xct);
        form.method = "POST";
        chunkSize = 1024 * 1024;
        i = 0;
        while (enc.length > 0) {
          next_chunk = "";
          if (enc.length < chunkSize) {
            chunk = enc;
            enc = "";
          } else {
            chunk = enc.substr(0, chunkSize);
            enc = enc.substr(chunkSize);
          }
          input = document.createElement("input");
          input.type = "hidden";
          input.name = "data_" + i++;
          input.value = chunk;
          form.appendChild(input);
        }
        del = function() {
          document.body.removeChild(ifr);
          return document.body.removeChild(form);
        };
        ifr.onload = form.onload = del;
        form.submit();
        return setTimeout((function() {
          try {
            return del();
          } catch (_error) {}
        }), 10000);
      };
      emit_method = function(enc) {
        return emitAsIframePost(enc);
      };
      emitAsImage = function(enc) {
        var del, img, xct;
        try {
          img = document.createElement("iframe");
          img.style.display = "none";
          document.body.appendChild(img);
          xct = copy(ct);
          xct.oz_df = nowdf();
          xct.oz_p = enc;
          img.src = postdest + "/postback?" + makeUrlString(xct);
          del = function() {
            document.body.removeChild(img);
            worked.img = true;
            return img = null;
          };
          img.onload = del;
          return null;
        } catch (_error) {}
      };
      emitAsCORSXHR = function(enc) {
        var xct, xhr;
        try {
          xhr = "";
          xhr = getCORS();
          if (xhr == null) {
            return;
          }
          xct = copy(ct);
          xct.oz_df = nowdf();
          try {
            xhr.withCredentials = false;
          } catch (_error) {}
          xhr.open('POST', postdest + "/postback?" + makeUrlString(xct), true);
          xhr.setRequestHeader('Content-type', 'application/json; charset=utf-8');
          xhr.send(enc);
          return xhr.onreadystatechange = function() {
            if (xhr.readyState === 4) {
              return emit_method = emitAsCORSXHR;
            }
          };
        } catch (_error) {}
      };
      emitAsCORSXHR(JSON.stringify([
        {
          method_cors: true
        }
      ]));
      emitAsImage(JSON.stringify([
        {
          method_img: true
        }
      ]));
      emitAsIframePost(JSON.stringify([
        {
          method_post: true
        }
      ]));
      getScd = function() {
        var scd, xct;
        xct = copy(ct);
        xct.oz_df = nowdf();
        scd = new Image();
        scd.style.display = "none";
        scd.src = "//" + sc + "." + getRandom(16) + ".sc." + os + "/two.gif?" + makeUrlString(xct);
        return document.body.appendChild(scd);
      };
      createSimplePingbacks = function() {
        var p_iframe, p_img, p_link, p_script, pbaddr, xct;
        p_iframe = document.createElement("iframe");
        p_link = document.createElement("link");
        p_img = document.createElement("img");
        p_script = document.createElement("script");
        p_iframe.style.display = p_link.style.display = p_img.style.display = p_script.style.display = "none";
        xct = copy(ct);
        xct.oz_df = nowdf();
        xct.oz_t = "XXXX";
        xct.oz_cb = String(Math.random()) + String(Math.random());
        pbaddr = proto + postdest + "/pb?" + makeUrlString(xct);
        p_iframe.src = pbaddr.replace("XXXX", "iframe");
        p_img.src = pbaddr.replace("XXXX", "img");
        p_link.rel = "stylesheet";
        p_script.src = pbaddr.replace("XXXX", "link");
        document.body.appendChild(p_iframe);
        document.body.appendChild(p_link);
        return document.body.appendChild(p_img);
      };
      btdata = {
        a: [
          Number((function() {
            try {
              return (screen.availHeight <= 1) || (screen.availWidth <= 1);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (screen.colorDepth <= 8) || (screen.pixelDepth <= 8) || (screen.devicePixelRatio <= 0);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (screen.height <= 1) || (screen.width <= 1);
            } catch (_error) {}
          })()) || 0
        ],
        b: [
          Number((function() {
            try {
              if ((typeof top !== "undefined" && top !== null) && (top.window != null) && (top.window.name != null)) {
                return top.window.name.indexOf('driver') > -1;
              }
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return Boolean(window.status) || Boolean(window.defaultStatus);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (document.click != null) && (document.documentElement.click.toString().indexOf('native code') === -1);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (document.documentElement.click != null) && (document.documentElement.click.toString().indexOf('native code') === -1);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return document.documentElement.hasAttribute('webdriver') || (window.domAutomation != null) || (window.domAutomationController != null) || (window._WEBDRIVER_ELEM_CACHE != null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.__proto__.toString().indexOf("DOMWindowPrototype") > -1 && (Array(window.external).toString().indexOf('JavaScriptExternalObject') > -1);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window._phantom != null) || (window.callPhantom != null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window._WEBDRIVER_ELEM_CACHE != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.isExternalUrlSafeForNavigation != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.opera != null) && (window.opera._browserjsran != null) && (window.opera.browserjsran === 0);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.opera != null) && (window.opera._browserjsran != null) && (window.opera.browserjsran === false);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.script.src.indexOf('page.js') > -1;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.webdriver != null) || (document.webdriver != null) || document.documentElement.hasAttribute('webdriver');
            } catch (_error) {}
          })()) || 0
        ],
        c: [
          Number((function() {
            try {
              return (window.external === window.external) && (typeof window.ActiveXObject === 'function');
            } catch (_error) {}
          })()) || 0, 0, Number((function() {
            try {
              return ((window.global != null) && (window.chrome != null)) || ((window.chrome != null) && (window.chrome.extension != null)) || ((window.chrome != null) && (window.chrome.internals != null));
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.maxConnectionsPerServer !== 6) && (window.maxConnectionsPerServer !== 16) && (window.ActiveXObject != null) && (window.external === window.external);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return 0 === 1;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return false === true;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return navigator.onLine === false;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (typeof document === "undefined" || document === null) || (window.screen == null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return typeof document === "undefined" || document === null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.screen == null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.chrome != null) && ((window.chrome.send != null) || (window.chrome.benchmarking != null));
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.chrome != null) && (window.chrome.extension != null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.chrome != null) && (window.chrome.internals != null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.chrome != null) && (window.chrome.send != null) || (window.chrome.benchmarking != null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.click != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.closed;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.external === window.external) && (typeof window.ActiveXObject === 'function');
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.external != null) && window.external.toString().indexOf("RuntimeObject") > -1;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.FirefoxInterfaces('wdICoordinate', 'wdIMouse', 'wdIStatus');
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.XPCOMUtils != null;
            } catch (_error) {}
          })()) || 0
        ],
        d: [
          Number((function() {
            try {
              return Components.interfaces.nsICommandProcessor != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (Components.wdICoordinate != null) || (Components.wdIMouse != null) || (Components.wdIStatus != null) || (window.webdriver != null) || (document.webdriver != null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (typeof Components !== "undefined" && Components !== null) && (Components.classes != null);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return netscape.security.privilegemanager != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (typeof netscape !== "undefined" && netscape !== null) && (netscape.security != null) && (netscape.security.privilegemanager != null);
            } catch (_error) {}
          })()) || 0
        ],
        e: [
          Number((function() {
            try {
              return window.__IE_DEVTOOLBAR_CONSOLE_COMMAND_LINE != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window._FirebugCommandLine != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return window.chrome._commandLineAPI != null;
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.Debug != null) && (window.Debug.debuggerEnabled != null) && (window.Debug.debuggerEnabled === 1);
            } catch (_error) {}
          })()) || 0, Number((function() {
            try {
              return (window.Debug != null) && (window.Debug.debuggerEnabled != null) && (window.Debug.debuggerEnabled === true);
            } catch (_error) {}
          })()) || 0
        ],
        v: 1
      };
      emit([
        {
          bts: btdata
        }
      ]);
      doHello1 = function() {
        return emit([
          {
            hello: {
              h: 1,
              t: nowdf()
            }
          }
        ]);
      };
      doHello2 = function() {
        return emit([
          {
            hello: {
              h: 2,
              t: nowdf()
            }
          }
        ]);
      };
      doHello4 = function() {
        return emit([
          {
            hello: {
              h: 4,
              t: nowdf()
            }
          }
        ]);
      };
      doHello8 = function() {
        return emit([
          {
            hello: {
              h: 8,
              t: nowdf()
            }
          }
        ]);
      };
      doHello16 = function() {
        return emit([
          {
            hello: {
              h: 16,
              t: nowdf()
            }
          }
        ]);
      };
      doHello32 = function() {
        return emit([
          {
            hello: {
              h: 32,
              t: nowdf()
            }
          }
        ]);
      };
      getFrameDepth = function() {
        var i;
        i = 0;
        while (i <= 16) {
          if (top === eval("window" + new Array(i).join(".parent"))) {
            return i - 1;
          }
          i++;
        }
      };
      getViewport = function() {
        var a, e;
        e = window;
        a = "inner";
        if (!("innerWidth" in window)) {
          a = "client";
          e = document.documentElement || document.body;
        }
        return {
          width: e[a + "Width"],
          height: e[a + "Height"]
        };
      };
      flashvars = {};
      params = {
        menu: "false",
        scale: "noScale",
        allowFullscreen: "true",
        allowScriptAccess: "always",
        bgcolor: "#FFFFFF",
        wmode: "direct"
      };
      attributes = {};
      makeDiv = function(name, x, y) {
        var d;
        d = document.createElement("div");
        d.style.display = "none";
        d.id = name;
        return document.body.appendChild(d);
      };
      makeDiv("ozoki_ul");
      makeDiv("ozoki_br");
      createVizBase = function() {
        var attributes_br, attributes_ul, flashv, port, styleString;
        port = getViewport();
        styleString = "";
        styleString = "pointer-events: none; display: block; opacity: 0.0001; position: absolute; filter: 'progid:DXImageTransform.Microsoft.Alpha(Opacity=0.001)';'z-order': 100000";
        attributes_ul = {
          style: "left: 2px; top: 2px;" + styleString
        };
        attributes_br = {
          style: "left: " + String(port.width - 8) + "px; top: " + String(port.height - 4) + "px;" + styleString
        };
        flashv = swfobject.getFlashPlayerVersion();
        swfobject.embedSWF(proto + getdest + "/viz11.swf", "ozoki_ul", "2", "2", "11.2.0", "expressInstall.swf", {
          name: "ozoki_ul",
          sc: sc,
          st: now(),
          full: "true",
          proto: escape(proto),
          postdest: escape(postdest),
          ct: escape(makeUrlString(ct))
        }, params, attributes_ul);
        return swfobject.embedSWF(proto + getdest + "/viz11.swf", "ozoki_br", "2", "2", "11.2.0", "expressInstall.swf", {
          name: "ozoki_br",
          sc: sc,
          st: now(),
          full: "true",
          proto: escape(proto),
          postdest: escape(postdest),
          ct: escape(makeUrlString(ct))
        }, params, attributes_br);
      };
      setTimeout(createVizBase, 2000);
      createLatencyChecker = function() {
        var getHTML, getHTTP, getHTTPS, getJS, latHTML, latHTTP, latHTTPS, latJS;
        latJS = document.createElement("iframe");
        latHTTP = document.createElement("iframe");
        latHTTPS = document.createElement("iframe");
        latHTML = document.createElement("iframe");
        latJS.style.display = latHTTP.style.display = latHTTPS.style.display = latHTML.style.display = "none";
        getJS = function() {
          var xct;
          xct = copy(ct);
          xct.oz_meth = "js";
          xct.oz_df = nowdf();
          latJS.src = "http:" + postdest + "/lat?" + makeUrlString(xct);
          return document.body.appendChild(latJS);
        };
        getHTTP = function() {
          var xct;
          xct = copy(ct);
          xct.oz_meth = "http";
          xct.oz_df = nowdf();
          latHTTP.src = "http:" + postdest + "/lat?" + makeUrlString(xct);
          return document.body.appendChild(latHTTP);
        };
        getHTTPS = function() {
          var xct;
          xct = copy(ct);
          xct.oz_meth = "https";
          xct.oz_df = nowdf();
          latHTTP.src = "https:" + postdest + "/lat?" + makeUrlString(xct);
          return document.body.appendChild(latHTTPS);
        };
        getHTML = function() {
          var xct;
          xct = copy(ct);
          xct.oz_meth = "html";
          xct.oz_df = nowdf();
          latHTML.src = "http:" + postdest + "/lat?" + makeUrlString(xct);
          return document.body.appendChild(latHTML);
        };
        getHTTP();
        setTimeout(getJS, 2000);
        setTimeout(getHTTPS, 4000);
        return setTimeout(getHTML, 6000);
      };
      collectWebGL = function() {
        var context, cv, gl, glstat, i, name, names, _i, _j, _len, _len1, _ref;
        try {
          glstat = {};
          glstat.webgl = false;
          try {
            if (window.WebGLRenderingContext == null) {
              return glstat;
            }
            glstat.webgl = true;
            glstat.canvas = false;
            cv = document.createElement("canvas");
            if (cv == null) {
              return glstat;
            }
            glstat.canvas = true;
            names = ["webgl", "experimental-webgl", "moz-webgl", "webkit-3d"];
            glstat.names = [];
            gl = null;
            for (_i = 0, _len = names.length; _i < _len; _i++) {
              name = names[_i];
              context = cv.getContext(name);
              if ((context != null) && typeof context.getParameter === "function") {
                glstat.names.push(name);
                if (gl == null) {
                  gl = context;
                }
              }
            }
            if (!gl) {
              return glstat;
            }
            glstat.getParameter = {};
            _ref = [2849, 2884, 2885, 2886, 2928, 2929, 2930, 2931, 2932, 2960, 2961, 2962, 2963, 2964, 2965, 2966, 2967, 2968, 2978, 3024, 3042, 3088, 3089, 3106, 3107, 3317, 3333, 3379, 3386, 3408, 3410, 3411, 3412, 3413, 3414, 3415, 7936, 7937, 7938, 10752, 32773, 32777, 32823, 32824, 32936, 32937, 32938, 32939, 32968, 32969, 32970, 32971, 33170, 33901, 33902, 34016, 34024, 34076, 34467, 34816, 34817, 34818, 34819, 34877, 34921, 34930, 35660, 35661, 35724, 36003, 36004, 36005, 36345, 36347, 36348, 36349, 37440, 37441, 37443];
            for (_j = 0, _len1 = _ref.length; _j < _len1; _j++) {
              i = _ref[_j];
              try {
                glstat.getParameter[i] = gl.getParameter(i);
              } catch (_error) {}
            }
          } catch (_error) {}
          return glstat;
        } catch (_error) {}
      };
      collectInitdata = function() {
        var externalnames, i, results, s, _i, _j, _k, _l, _len, _len1, _len2, _len3, _ref, _ref1, _ref2, _ref3;
        results = {};
        try {
          if ((document.location != null) && (document.location.href != null)) {
            results["document_location_href"] = JSON.parse(JSON.stringify(document.location.href));
          }
        } catch (_error) {}
        try {
          if (document.referrer != null) {
            results["document_referrer"] = JSON.parse(JSON.stringify(document.referrer));
          }
        } catch (_error) {}
        try {
          if ((typeof performance !== "undefined" && performance !== null) && (performance.timing != null)) {
            results["performance_timing"] = JSON.parse(JSON.stringify(performance.timing));
          }
        } catch (_error) {}
        try {
          if (typeof maxConnectionsPerServer !== "undefined" && maxConnectionsPerServer !== null) {
            results["maxConnectionsPerServer"] = JSON.parse(JSON.stringify(maxConnectionsPerServer));
          }
        } catch (_error) {}
        try {
          if (typeof status !== "undefined" && status !== null) {
            results["status"] = JSON.parse(JSON.stringify(status));
          }
        } catch (_error) {}
        try {
          if (typeof defaultStatus !== "undefined" && defaultStatus !== null) {
            results["defaultStatus"] = JSON.parse(JSON.stringify(defaultStatus));
          }
        } catch (_error) {}
        try {
          if (typeof defaultstatus !== "undefined" && defaultstatus !== null) {
            results["defaultstatus"] = JSON.parse(JSON.stringify(defaultstatus));
          }
        } catch (_error) {}
        try {
          if ((typeof performance !== "undefined" && performance !== null) && (performance.memory != null)) {
            results["performance_memory"] = JSON.parse(JSON.stringify(performance.memory));
          }
        } catch (_error) {}
        try {
          if (typeof screen !== "undefined" && screen !== null) {
            results["screen"] = JSON.parse(JSON.stringify(screen));
          }
        } catch (_error) {}
        try {
          if (screen.availHeight != null) {
            results["screen_availHeight"] = JSON.parse(JSON.stringify(screen.availHeight));
          }
        } catch (_error) {}
        try {
          if (screen.height != null) {
            results["screen_height"] = JSON.parse(JSON.stringify(screen.height));
          }
        } catch (_error) {}
        try {
          if (typeof mozPaintCount !== "undefined" && mozPaintCount !== null) {
            results["mozPaintCount"] = JSON.parse(JSON.stringify(mozPaintCount));
          }
        } catch (_error) {}
        try {
          if ((typeof stylemedia !== "undefined" && stylemedia !== null) && (styleMedia.type != null)) {
            results["styleMedia_type"] = JSON.parse(JSON.stringify(styleMedia.type));
          }
        } catch (_error) {}
        try {
          if (history.length != null) {
            results["history_length"] = JSON.parse(JSON.stringify(history.length));
          }
        } catch (_error) {}
        try {
          if (typeof external !== "undefined" && external !== null) {
            results["external"] = JSON.parse(JSON.stringify(external));
          }
        } catch (_error) {}
        try {
          if (typeof opener !== "undefined" && opener !== null) {
            results["opener"] = JSON.parse(JSON.stringify(opener));
          }
        } catch (_error) {}
        try {
          if (typeof __proto__ !== "undefined" && __proto__ !== null) {
            results["__proto__"] = JSON.parse(JSON.stringify(__proto__));
          }
        } catch (_error) {}
        try {
          if (navigator.userAgent != null) {
            results["navigator_userAgent"] = JSON.parse(JSON.stringify(navigator.userAgent));
          }
        } catch (_error) {}
        try {
          if (typeof fileCreatedDate !== "undefined" && fileCreatedDate !== null) {
            results["fileCreatedDate"] = JSON.parse(JSON.stringify(fileCreatedDate));
          }
        } catch (_error) {}
        try {
          if (typeof fileModifiedDate !== "undefined" && fileModifiedDate !== null) {
            results["fileModifiedDate"] = JSON.parse(JSON.stringify(fileModifiedDate));
          }
        } catch (_error) {}
        try {
          if (typeof fileUpdatedDate !== "undefined" && fileUpdatedDate !== null) {
            results["fileUpdatedDate"] = JSON.parse(JSON.stringify(fileUpdatedDate));
          }
        } catch (_error) {}
        try {
          if (typeof lastModified !== "undefined" && lastModified !== null) {
            results["lastModified"] = JSON.parse(JSON.stringify(lastModified));
          }
        } catch (_error) {}
        try {
          if (location.href != null) {
            results["location_href"] = JSON.parse(JSON.stringify(location.href));
          }
        } catch (_error) {}
        try {
          if (typeof protocol !== "undefined" && protocol !== null) {
            results["protocol"] = JSON.parse(JSON.stringify(protocol));
          }
        } catch (_error) {}
        try {
          if (typeof name !== "undefined" && name !== null) {
            results["name"] = JSON.parse(JSON.stringify(name));
          }
        } catch (_error) {}
        try {
          if (location.href != null) {
            results["location_href"] = JSON.parse(JSON.stringify(location.href));
          }
        } catch (_error) {}
        try {
          if (location.ancestorOrigins != null) {
            results["location_ancestorOrigins"] = JSON.parse(JSON.stringify(location.ancestorOrigins));
          }
        } catch (_error) {}
        try {
          if (typeof hidden !== "undefined" && hidden !== null) {
            results["hidden"] = JSON.parse(JSON.stringify(hidden));
          }
        } catch (_error) {}
        try {
          if (typeof visibilityState !== "undefined" && visibilityState !== null) {
            results["visibilityState"] = JSON.parse(JSON.stringify(visibilityState));
          }
        } catch (_error) {}
        try {
          results["iframe_depth"] = getFrameDepth();
        } catch (_error) {}
        try {
          results["viewport"] = getViewport();
        } catch (_error) {}
        results["screen"] = {};
        try {
          if (typeof screen !== "undefined" && screen !== null) {
            results["screen"] = JSON.parse(JSON.stringify(screen));
          }
        } catch (_error) {}
        externalnames = {};
        _ref = ["ShowBrowserUI", "raiseEvent", "NavigateAndFind", "msSiteModeShowJumpList", "msReportSafeUrl", "msIsSiteMode", "msActiveXFilteringEnabled", "AutoScan", "AddC" + "hannel", "AddSearchProvider"];
        for (_i = 0, _len = _ref.length; _i < _len; _i++) {
          i = _ref[_i];
          try {
            if (typeof window.external[i] === "unknown") {
              externalnames[i] = 1;
            }
          } catch (_error) {}
        }
        try {
          _ref1 = get_keys(window.external);
          for (_j = 0, _len1 = _ref1.length; _j < _len1; _j++) {
            i = _ref1[_j];
            externalnames[i] = 1;
          }
        } catch (_error) {}
        _ref2 = ["AddSearchProvider", "IsSearchProviderInstalled", "QueryInterface", "addPanel", "addPersistentPanel", "addSearchEngine"];
        for (_k = 0, _len2 = _ref2.length; _k < _len2; _k++) {
          i = _ref2[_k];
          try {
            if (typeof window.external[i] === "function") {
              externalnames[i] = 1;
            }
          } catch (_error) {}
        }
        results["externalnames"] = Object.keys(externalnames);
        _ref3 = get_keys(window.screen);
        for (_l = 0, _len3 = _ref3.length; _l < _len3; _l++) {
          i = _ref3[_l];
          try {
            s = window.screen[i];
            if (typeof s === "number" || typeof s === "string") {
              results["screen"][i] = s;
            } else {
              results["screen"][i] = typeof s;
            }
          } catch (_error) {}
        }
        return results;
      };
      makePrint = function(obj, i) {
        var res;
        res = {};
        try {
          res.name = i;
        } catch (_error) {}
        try {
          res.typ = typeof obj[i];
        } catch (_error) {}
        if (typeof obj[i] !== "boolean") {
          try {
            res.bool = Boolean(obj[i]);
          } catch (_error) {}
        }
        return res;
      };
      get_keys = function(obj) {
        var i, x, _i, _j, _k, _len, _len1, _len2, _ref, _ref1;
        x = {};
        try {
          for (_i = 0, _len = obj.length; _i < _len; _i++) {
            i = obj[_i];
            x[i] = 1;
          }
        } catch (_error) {}
        try {
          for (i in obj) { x[i]=1; };
        } catch (_error) {}
        try {
          _ref = Object.getOwnPropertyNames(obj);
          for (_j = 0, _len1 = _ref.length; _j < _len1; _j++) {
            i = _ref[_j];
            x[i] = 1;
          }
        } catch (_error) {}
        try {
          _ref1 = Object.Keys(obj);
          for (_k = 0, _len2 = _ref1.length; _k < _len2; _k++) {
            i = _ref1[_k];
            x[i] = 1;
          }
        } catch (_error) {}
        return Object.Keys(x);
      };
      curiousDump = function(obj) {
        var i, k, x, y, _i, _len;
        x = get_keys(obj);
        y = [];
        try {
          k = x;
          for (_i = 0, _len = k.length; _i < _len; _i++) {
            i = k[_i];
            y.push(makePrint(obj, i));
          }
        } catch (_error) {}
        return y;
      };
      collectPlugins = function() {
        var mimeType, mimeType_data, plugin, plugin_data, plugins, _i, _j, _len, _len1, _ref;
        plugins = [];
        _ref = navigator.plugins;
        for (_i = 0, _len = _ref.length; _i < _len; _i++) {
          plugin = _ref[_i];
          try {
            plugin_data = {
              description: plugin.description,
              filename: plugin.filename,
              name: plugin.name
            };
            plugin_data.mimeTypes = [];
            for (_j = 0, _len1 = plugin.length; _j < _len1; _j++) {
              mimeType = plugin[_j];
              try {
                mimeType_data = {
                  description: mimeType.description,
                  suffixes: mimeType.suffixes,
                  type: mimeType.type
                };
                plugin_data.mimeTypes.push(mimeType_data);
              } catch (_error) {}
            }
            plugins.push(plugin_data);
          } catch (_error) {}
        }
        return plugins;
      };
      createMouseChecker = function() {
        var drain_mouse, eprev, mouse_queue, mousecount, old_onclick, old_onmousedown, old_onmousemove, old_onmouseover, old_onmouseup, prev, show_info, xprev, yprev;
        old_onmousemove = document.body.onmousemove;
        old_onmouseover = document.body.onmouseover;
        old_onmousedown = document.body.onmousedown;
        old_onmouseup = document.body.onmouseup;
        old_onclick = document.body.onclick;
        mousecount = 0;
        document.body.onmousemove = function(e) {
          return show_info(old_onmousemove, e, false);
        };
        document.body.onmouseover = function(e) {
          return show_info(old_onmouseover, e, false);
        };
        document.body.onmousedown = function(e) {
          return show_info(old_onmousedown, e, false);
        };
        document.body.onmouseup = function(e) {
          return show_info(old_onmouseup, e, false);
        };
        document.body.onclick = function(e) {
          return show_info(old_onclick, e, true);
        };
        mouse_queue = [];
        prev = eprev = now();
        xprev = yprev = 0;
        show_info = function(prev_event, e, force) {
          var report;
          if (mousecount++ > 256) {
            if (prev_event !== null) {
              prev_event(e)();
            }
            return;
          }
          try {
            report = {
              mouse: {
                atd: nowdf(),
                td: now() - prev,
                etd: e.timeStamp - eprev,
                cx: e.clientX - xprev,
                cy: e.clientY - yprev,
                ty: e.type,
                w: e.which
              }
            };
            prev = now();
            eprev = e.timeStamp;
            xprev = e.clientX;
            yprev = e.clientY;
            if (mouse_queue.length === 0 && force === false) {
              setTimeout(drain_mouse, 2000);
            }
            mouse_queue.push(report);
            if (force === true) {
              drain_mouse();
            }
            if (prev_event !== null) {
              return prev_event(e)();
            }
          } catch (_error) {}
        };
        return drain_mouse = function() {
          if (mouse_queue.length > 0) {
            emit(mouse_queue);
          }
          return mouse_queue = [];
        };
      };
      createMouseChecker();
      RAF_prev_average = 0;
      createRAFChecker = function() {
        var count, fire_step_anyway, hits, prev_tsdiff, requestAnimationFrame, step, timeout;
        requestAnimationFrame = window.requestAnimationFrame || window.mozRequestAnimationFrame || window.webkitRequestAnimationFrame || window.msRequestAnimationFrame;
        if (requestAnimationFrame == null) {
          return;
        }
        count = 0;
        hits = [];
        prev_tsdiff = 0;
        timeout = null;
        step = function(timeStamp) {
          var average, diff, stamp, _i, _len;
          clearTimeout(timeout);
          if (count++ === 0) {
            prev_tsdiff = timeStamp;
            requestAnimationFrame(step);
            return;
          }
          hits.push(timeStamp - prev_tsdiff);
          prev_tsdiff = timeStamp;
          if (count <= 10) {
            return requestAnimationFrame(step);
          } else {
            average = 0;
            for (_i = 0, _len = hits.length; _i < _len; _i++) {
              stamp = hits[_i];
              average += stamp;
            }
            average /= 10;
            diff = Math.abs(average - RAF_prev_average);
            if (diff > 5) {
              emit([
                {
                  rafmark: {
                    df: nowdf(),
                    average: average,
                    raw: hits
                  }
                }
              ]);
            }
            RAF_prev_average = average;
            count = 0;
            hits = [];
            return setTimeout(createRAFChecker, 2 * 1000);
          }
        };
        requestAnimationFrame(step);
        fire_step_anyway = function() {
          console.log("fired timeout anyway");
          if (triggered === false) {
            return step(now())();
          }
        };
        return timeout = setTimeout(fire_step_anyway, 10 * 1000);
      };
      createStorageChecker = function() {
        var e;
        try {
          return window.webkitStorageInfo.queryUsageAndQuota(webkitStorageInfo.TEMPORARY, (function(used, remaining) {
            return emit([
              {
                quota: {
                  used: used,
                  remaining: remaining
                }
              }
            ]);
          }), function(e) {
            return emit([
              {
                error: {
                  source: "storage",
                  message: JSON.stringify(e.message)
                }
              }
            ]);
          });
        } catch (_error) {
          e = _error;
          return emit([
            {
              error: {
                source: "storage_outside",
                message: JSON.stringify(e.message)
              }
            }
          ]);
        }
      };
      createVisibilityEvent = function() {
        var handleVisChange, hidden, visibilityChange;
        try {
          hidden = visibilityChange = void 0;
          handleVisChange = function(e) {
            try {
              return emit([
                {
                  vizapi: {
                    time: nowdf(),
                    hidden: document[hidden],
                    visibilityState: document.visibilityState
                  }
                }
              ]);
            } catch (_error) {}
          };
          if (typeof document.hidden !== "undefined") {
            hidden = "hidden";
            visibilityChange = "visibilitychange";
          } else if (typeof document.mozHidden !== "undefined") {
            hidden = "mozHidden";
            visibilityChange = "mozvisibilitychange";
          } else if (typeof document.msHidden !== "undefined") {
            hidden = "msHidden";
            visibilityChange = "msvisibilitychange";
          } else if (typeof document.webkitHidden !== "undefined") {
            hidden = "webkitHidden";
            visibilityChange = "webkitvisibilitychange";
          }
          document.addEventListener(visibilityChange, handleVisChange, false);
          return handleVisChange();
        } catch (_error) {}
      };
      createVisibilityEvent();
      createDomChecker = function() {
        var battery, bdata, i, ifr, initdata, plugins, pn, wo, wodoc, _i, _len;
        initdata = collectInitdata();
        try {
          initdata.document_scripts = ifr.contentDocument.scripts.length;
        } catch (_error) {}
        try {
          initdata.swfversion = swfobject.getFlashPlayerVersion();
        } catch (_error) {}
        emit([
          {
            initdata: initdata
          }
        ]);
        return;
        battery = navigator.battery || navigator.webkitBattery || navigator.mozBattery;
        bdata = {};
        if (battery != null) {
          try {
            bdata.charging = battery.charging;
          } catch (_error) {}
          try {
            bdata.level = battery.level;
          } catch (_error) {}
          try {
            bdata.dischargingTime = battery.dischargingTime;
          } catch (_error) {}
        }
        emit([
          {
            battery: bdata
          }, {
            webgl: collectWebGL()
          }
        ]);
        ifr = document.createElement("iframe");
        ifr.style.display = "none";
        document.body.appendChild(ifr);
        wo = get_keys(ifr.contentWindow);
        wodoc = get_keys(ifr.contentDocument);
        plugins = collectPlugins();
        pn = {};
        for (_i = 0, _len = plugins.length; _i < _len; _i++) {
          i = plugins[_i];
          pn[i.filename] = 1;
        }
        return pn = get_keys(pn);
      };
      createDomChecker();
      return createHTML5Checker = function() {
        var report_results, t;
        report_results = function(r) {
          var kv, rx, x, _i, _len, _ref;
          rx = {};
          rx.score = r.score;
          rx.uniqueid = r.uniqueid;
          rx.results = {};
          _ref = r.results.split(",");
          for (_i = 0, _len = _ref.length; _i < _len; _i++) {
            x = _ref[_i];
            kv = x.split("=");
            rx.results[kv[0]] = kv[1];
          }
          return emit([
            {
              html5: rx
            }
          ]);
        };
        return t = new Test(report_results);
      };
    };
    get_sc_last_resort = function(n) {
      var getSc, get_str, to_hash;
      get_str = function() {
        var str, then_;
        str = "";
        then_ = now();
        while (now() - then_ < 18) {
          str += Math.random() + now();
        }
        return str;
      };
      to_hash = function(str) {
        var i, prefix, s;
        s = fnv_1a(str).toString(16).replace("-", "");
        prefix = "";
        i = (s.length * 2) - 1;
        while (i < 8) {
          prefix += "0";
          i++;
        }
        return prefix + s;
      };
      getSc = function(bytes) {
        var s, words;
        words = bytes / 4;
        s = "";
        while (words--) {
          s += to_hash(get_str());
        }
        return s;
      };
      return getSc(n);
    };
    get_sc_remote = function() {
      var scr, str;
      scr = window.document.createElement("script");
      scr.async = true;
      scr.type = "text/javascript";
      str = postdest + "/sc.js?" + String(Math.random());
      scr.src = str;
      return document.body.appendChild(scr);
    };
    sc_checked = 0;
    check_for_sc = function() {
      if ((window.ozoki_sc != null) && document.readyState === 'complete' && (typeof document !== "undefined" && document !== null) && (document.body != null) && (document.body.appendChild != null)) {
        sc = ct.oz_sc = window.ozoki_sc;
        return go_on();
      } else if (sc_checked++ < 64) {
        return setTimeout(check_for_sc, 200);
      }
    };
    getRandom = function(bytecount) {
      var bytes, hexbytes, i, outstr, x, _i, _len;
      if ((window.crypto != null) && (window.crypto.getRandomValues != null) && (window.Uint8Array != null)) {
        hexbytes = [];
        bytes = new Uint8Array(bytecount);
        window.crypto.getRandomValues(bytes);
        for (_i = 0, _len = bytes.length; _i < _len; _i++) {
          i = bytes[_i];
          x = i.toString(16);
          if (x.length === 1) {
            x = "0" + x;
          }
          hexbytes.push(x);
        }
        outstr = hexbytes.join('');
        return outstr;
      } else {
        get_sc_remote();
        return "";
      }
    };
    window.ozoki_sc = getRandom(12);
    check_for_sc();
  }

}).call(this);
