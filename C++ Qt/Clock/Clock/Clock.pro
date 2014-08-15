#-------------------------------------------------
#
# Project created by QtCreator 2014-08-14T19:06:25
#
#-------------------------------------------------

QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = Clock
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    circle.cpp \
    time.cpp

HEADERS  += mainwindow.h \
    circle.h \
    time.h

FORMS    += mainwindow.ui
