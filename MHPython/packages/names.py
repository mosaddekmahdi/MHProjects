#!/usr/bin/python

"""
names is a test module
"""

_version = 1.0  # non- importable

names = ["Mosaddek", "Muhaimin", "Mahdi", "Munim"]

def show_names():
   for i in names:
      print i

def _show_version():    # non- importable
   print _version
   

print locals()
