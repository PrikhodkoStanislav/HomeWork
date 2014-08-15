/********************************************************************************
** Form generated from reading UI file 'calculatorwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.2.1
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_CALCULATORWINDOW_H
#define UI_CALCULATORWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QAction>
#include <QtWidgets/QApplication>
#include <QtWidgets/QButtonGroup>
#include <QtWidgets/QComboBox>
#include <QtWidgets/QHeaderView>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QSpinBox>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QToolBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_CalculatorWindow
{
public:
    QWidget *centralWidget;
    QSpinBox *value1;
    QComboBox *operation;
    QSpinBox *value2;
    QLabel *label;
    QLineEdit *lineEdit;
    QMenuBar *menuBar;
    QToolBar *mainToolBar;
    QStatusBar *statusBar;

    void setupUi(QMainWindow *CalculatorWindow)
    {
        if (CalculatorWindow->objectName().isEmpty())
            CalculatorWindow->setObjectName(QStringLiteral("CalculatorWindow"));
        CalculatorWindow->resize(450, 200);
        CalculatorWindow->setMinimumSize(QSize(450, 200));
        CalculatorWindow->setMaximumSize(QSize(450, 200));
        CalculatorWindow->setMouseTracking(false);
        centralWidget = new QWidget(CalculatorWindow);
        centralWidget->setObjectName(QStringLiteral("centralWidget"));
        value1 = new QSpinBox(centralWidget);
        value1->setObjectName(QStringLiteral("value1"));
        value1->setGeometry(QRect(40, 40, 81, 61));
        value1->setMinimumSize(QSize(81, 61));
        value1->setMaximumSize(QSize(81, 16777215));
        value1->setMinimum(-10000);
        value1->setMaximum(10000);
        value1->setValue(0);
        operation = new QComboBox(centralWidget);
        operation->setObjectName(QStringLiteral("operation"));
        operation->setGeometry(QRect(140, 50, 71, 31));
        value2 = new QSpinBox(centralWidget);
        value2->setObjectName(QStringLiteral("value2"));
        value2->setGeometry(QRect(220, 40, 81, 61));
        value2->setMinimumSize(QSize(81, 61));
        value2->setMaximumSize(QSize(81, 61));
        value2->setMinimum(-10000);
        value2->setMaximum(10000);
        label = new QLabel(centralWidget);
        label->setObjectName(QStringLiteral("label"));
        label->setGeometry(QRect(320, 40, 21, 61));
        QFont font;
        font.setPointSize(20);
        label->setFont(font);
        lineEdit = new QLineEdit(centralWidget);
        lineEdit->setObjectName(QStringLiteral("lineEdit"));
        lineEdit->setGeometry(QRect(350, 40, 81, 61));
        lineEdit->setMouseTracking(true);
        lineEdit->setReadOnly(true);
        CalculatorWindow->setCentralWidget(centralWidget);
        menuBar = new QMenuBar(CalculatorWindow);
        menuBar->setObjectName(QStringLiteral("menuBar"));
        menuBar->setGeometry(QRect(0, 0, 450, 21));
        CalculatorWindow->setMenuBar(menuBar);
        mainToolBar = new QToolBar(CalculatorWindow);
        mainToolBar->setObjectName(QStringLiteral("mainToolBar"));
        CalculatorWindow->addToolBar(Qt::TopToolBarArea, mainToolBar);
        statusBar = new QStatusBar(CalculatorWindow);
        statusBar->setObjectName(QStringLiteral("statusBar"));
        CalculatorWindow->setStatusBar(statusBar);

        retranslateUi(CalculatorWindow);

        QMetaObject::connectSlotsByName(CalculatorWindow);
    } // setupUi

    void retranslateUi(QMainWindow *CalculatorWindow)
    {
        CalculatorWindow->setWindowTitle(QApplication::translate("CalculatorWindow", "Calculator", 0));
        operation->clear();
        operation->insertItems(0, QStringList()
         << QApplication::translate("CalculatorWindow", "+", 0)
         << QApplication::translate("CalculatorWindow", "-", 0)
         << QApplication::translate("CalculatorWindow", "*", 0)
         << QApplication::translate("CalculatorWindow", "/", 0)
        );
        label->setText(QApplication::translate("CalculatorWindow", "=", 0));
    } // retranslateUi

};

namespace Ui {
    class CalculatorWindow: public Ui_CalculatorWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_CALCULATORWINDOW_H
