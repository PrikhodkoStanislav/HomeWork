#include "cannonwindow.h"
#include "ui_cannonwindow.h"
#include "printer.h"

CannonWindow::CannonWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::CannonWindow)
{
    ui->setupUi(this);

    scene = new QGraphicsScene();
    view = new QGraphicsView(scene);
    QGraphicsItem *printer = new Printer();
    scene->addItem(printer);

    this->ui->centralWidget->layout()->addWidget(view);
}

CannonWindow::~CannonWindow()
{
    delete ui;
}
