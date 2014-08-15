#-------------------------------------------------
#
# Project created by QtCreator 2014-03-30T22:04:57
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = Calculator
TEMPLATE = app

CONFIG += C++11


SOURCES += main.cpp\
        calculatorwindow.cpp \
    calculator.cpp

HEADERS  += calculatorwindow.h \
    calculator.h

FORMS    += calculatorwindow.ui
